using System.Collections.Generic;

namespace PlanningCenter_to_OPS.Structs
{
    internal class Song
    {
        public int id { get; set; }
        public string name { get; set; }

        public Song (int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    internal class OpsSongs
    {
        public IDictionary<string, List<Song>> books { get; set; } = new Dictionary<string, List<Song>>();
    }
}
