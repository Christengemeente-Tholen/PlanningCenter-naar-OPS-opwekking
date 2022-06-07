using System;
using System.Linq;

namespace PlanningCenter_to_OPS.BookTypes
{
    internal class Opwekking : BookType
    {
        public override string SongBookName => "Opwekking";

        public override string StyleName => "OPS";

        public override string SelectedVersion => "ProjectionVersion";
    }
}
