using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PlanningCenter_to_OPS.Structs
{
    internal class SongListAttributes
    {
        public string title { get; set; }
        public string item_type { get; set; }
    }

    internal class SongListLinks
    {
        public string self { get; set; }
    }

    internal class SongListData
    {
        public SongListAttributes attributes { get; set; }
        public SongListLinks links { get; set; }
    }

    internal class SongList
    {
        public List<SongListData> data { get; set; }

        public static implicit operator SongList(XElement v)
        {
            throw new NotImplementedException();
        }
    }
}
