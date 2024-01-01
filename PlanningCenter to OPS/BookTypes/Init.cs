namespace PlanningCenter_to_OPS.BookTypes
{
    internal abstract class BookType
    {
        public abstract string SongBookName { get; }
        public abstract string StyleName { get; }
        public abstract string SelectedVersion { get; }

    }

    internal class Init
    {

        internal static BookType GetType(Config config, string song_type)
        {
            if (song_type == "opw")
            {
                return new Opwekking();
            } else if (song_type == "kopw")
            {
                return new KinderOpwekking();
            } else
            {
                return new EigenTeksten(config);
            }
        }
    }
}
