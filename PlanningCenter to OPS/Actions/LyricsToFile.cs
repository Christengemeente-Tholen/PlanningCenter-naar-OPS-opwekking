using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlanningCenter_to_OPS.Actions
{
    internal class LyricsToFile
    {
        private static readonly List<string> removed_if_line = [
            "vers",
            "verse",
            "couplet",
            "bridge",
            "misc",
            "pre-Chorus",
            "intermezzo",
            "intro",
            "tag",
            "interlude",
            "(repeat)",
            "verhoging",
        ];

        private static readonly string[] remove_text = {
            "<b>",
            "<i>",
            "<u>",
            "</b>",
            "</i>",
            "</u>"
        };

        public static string ReplaceWordChars(string text)
        {
            var s = text;
            // smart single quotes and apostrophe,  single low-9 quotation mark, single high-reversed-9 quotation mark, prime
            s = Regex.Replace(s, "[\u2018\u2019\u201A\u201B\u2032]", "'");
            // smart double quotes, double prime
            s = Regex.Replace(s, "[\u201C\u201D\u201E\u2033]", "\"");
            // ellipsis
            s = Regex.Replace(s, "\u2026", "...");
            // em dashes
            s = Regex.Replace(s, "[\u2013\u2014]", "-");
            // horizontal bar
            s = Regex.Replace(s, "\u2015", "-");
            // double low line
            s = Regex.Replace(s, "\u2017", "-");
            // circumflex
            s = Regex.Replace(s, "\u02C6", "^");
            // open angle bracket
            s = Regex.Replace(s, "\u2039", "<");
            // close angle bracket
            s = Regex.Replace(s, "\u203A", ">");
            // weird tilde and nonblocking space
            s = Regex.Replace(s, "[\u02DC\u00A0]", " ");
            // half
            s = Regex.Replace(s, "[\u00BD]", "1/2");
            // quarter
            s = Regex.Replace(s, "[\u00BC]", "1/4");
            // dot
            s = Regex.Replace(s, "[\u2022]", "*");
            // degrees 
            s = Regex.Replace(s, "[\u00B0]", " degrees");

            return s;
        }

        internal static string Lyrics(string lyrics, List<string> skip_list)
        {

            string[] current_lyrics = lyrics.Split(
                new string[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );
            string cleaned_lyrics = "";

            string previous_line = "";
            foreach (string line in current_lyrics)
            {
                string mut_line = line;
                foreach (var item in remove_text)
                {
                    mut_line = Regex.Replace(mut_line, item, "");
                }
                // if value not in RemovedText or if added to skip_list
                var regex = new Regex(string.Format(@"^\b(?:{0})\b(| \d| \dx)$", string.Join("|", removed_if_line)), RegexOptions.Compiled);
                if (!regex.Match(mut_line.Trim().ToLower()).Success || skip_list.Any(s => s == mut_line))
                {
                    // Use skiplist to make it a header item when needed
                    if (skip_list.Contains(mut_line.Trim().ToLower().Replace(":", "") + ":"))
                    {
                        cleaned_lyrics += mut_line.Trim() + ":\r\n";
                    }
                    else
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(ReplaceWordChars(mut_line));
                        char[] chars = Encoding.ASCII.GetChars(bytes);
                        string result = new(chars);
                        result = result.Replace("?", "");

                        // skip the line if current and previous result are both empty
                        if (!(previous_line == "" && result == ""))
                        {
                            cleaned_lyrics += result + "\r\n";
                        }
                        previous_line = result;
                    }
                }
            }

            return cleaned_lyrics;
        }

        internal static void ToFile(Config config, Structs.SongListData song)
        {

            Structs.Lyrics lyrics_return = Api.GetLyrics(config, song.links.self);
            if (lyrics_return.data.attributes.lyrics != null)
            {
                string cleaned_lyrics = Lyrics(lyrics_return.data.attributes.lyrics, config.skip_list);
                try
                {
                    File.WriteAllText(Path.Combine(config.song_folder, String.Format("{0}.txt", song.attributes.title)), cleaned_lyrics);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(String.Format("locatie {0} niet gevonden, probeer een andere opslaglocatie voor de liedjes", config.song_folder));
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        config.song_folder = dialog.SelectedPath;
                        config.Update();
                    }
                }
            }
        }
    }
}
