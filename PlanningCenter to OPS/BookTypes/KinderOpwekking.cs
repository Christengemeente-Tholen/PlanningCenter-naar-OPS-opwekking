using System;
using System.Linq;

namespace PlanningCenter_to_OPS.BookTypes
{
    internal class KinderOpwekking : BookType
    {
        public override string SongBookName => "Kinderen";

        public override string StyleName => "OPS";

        public override string SelectedVersion => "ProjectionVersion";
    }
}
