using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal static BookType GetType(string song_type)
        {
            if (song_type == "opw")
            {
                return new Opwekking();
            } else
            {
                return new Opwekking();
            }
        }
    }
}
