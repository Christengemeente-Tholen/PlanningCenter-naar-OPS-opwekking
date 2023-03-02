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
        private static readonly string[] removed_text = {
            "Verse 1",
            "Verse 2",
            "Verse 3",
            "Verse 4",
            "Verse 5",
            "Couplet 1",
            "Couplet 2",
            "Couplet 3",
            "Couplet 4",
            "Couplet 5",
            "(Bridge",
            "Misc 1",
            "Misc 2",
            "Misc 3",
            "Misc 4",
            "Misc 5",
            "(Pre-Chorus)",
            "INTERMEZZO",
            "INTRO",
            "(TAG)",
            "(Interlude)",
            "(REPEAT)",
            "Verhoging",
            "</b>",
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

        internal static void ToFile(Config config, Structs.SongListData song)
        {
            Structs.Lyrics lyrics_return = Api.GetLyrics(config, song.links.self);
            if (lyrics_return.data.attributes.lyrics != null)
            {
                string[] current_lyrics = lyrics_return.data.attributes.lyrics.Split(
                    new string[] { "\r\n", "\r", "\n" },
                    StringSplitOptions.None
                );
                string cleaned_lyrics = "";

                foreach (string line in current_lyrics)
                {
                    // if value not in RemovedText
                    if (!removed_text.Any(s => line.ToLower().Contains(s.ToLower())))
                    {
                        // replace chorus with ops eqivelant
                        Dictionary<string, string> translate_to_ops = new Dictionary<string, string>() {
                            { "chorus", "Chorus:" },
                            { "chorus 1", "Chorus 1:"},
                            { "chorus 2", "Chorus 2:"},
                            { "chorus 3", "Chorus 3:"},
                            { "bridge", "Bridge:" },
                            { "bridge 2x", "Bridge 2x:" },
                            { "refrein", "Refrein:" },
                            { "refrein 1", "Refrein 1:"},
                            { "refrein 2", "Refrein 2:"},
                            { "refrein 3", "Refrein 3:"},
                        };

                        string translated_ops;
                        if (translate_to_ops.TryGetValue(line.ToLower().Replace(":", ""), out translated_ops))
                        {
                            cleaned_lyrics += translated_ops + "\r\n";
                        } else
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes(ReplaceWordChars(line));
                            char[] chars = Encoding.ASCII.GetChars(bytes);
                            string result = new (chars);
                            result = result.Replace("?", "");
                            cleaned_lyrics += result + "\r\n";
                        }
                    }
                }

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
