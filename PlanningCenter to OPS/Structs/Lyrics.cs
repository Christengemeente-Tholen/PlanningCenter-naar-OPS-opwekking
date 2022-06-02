namespace PlanningCenter_to_OPS.Structs
{
    internal class LyricsAttributes
    {
        public string lyrics { get; set; }
    }

    internal class LyricsData
    {
        public LyricsAttributes attributes { get; set; }
    }

    internal class Lyrics
    {
        public LyricsData data { get; set; }
    }
}
