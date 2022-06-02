namespace PlanningCenter_to_OPS.BookTypes
{
    internal abstract class BookType
    {
        protected string song_name;
        public abstract string SongName { get; }
        public abstract string SongNumber { get; }
        public abstract string Title { get; }
        public abstract string SongBookName { get; }
        public abstract string StyleName { get; }
        public abstract string SelectedVersion { get; }

    }

    internal class Init
    {

        internal static BookType GetType(string song_type, string song_name)
        {
            if (song_type == "opw")
            {
                return new Opwekking(song_name);
            } else if (song_type == "kopw")
            {
                return new KinderOpwekking(song_name);
            } else
            {
                return new Opwekking(song_name);
            }
        }
    }
}
