using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningCenter_to_OPS.BookTypes
{
    internal class Opwekking : BookType
    {
        public override string SongBookName => "Opwekking";

        public override string StyleName => "OPS";

        public override string SelectedVersion => "ProjectionVersion";
    }
}
