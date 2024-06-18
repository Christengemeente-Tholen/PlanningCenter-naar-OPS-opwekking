using System.Collections.Generic;

namespace PlanningCenter_to_OPS.Structs
{
    internal class Song
    {
        public int id { get; set; }
        public string name { get; set; }
        public string first_line { get; set; }

        public Song (int id, string name, string first_line)
        {
            this.id = id;
            this.name = name;
            this.first_line = first_line;
        }
    }

    internal class OpsSongs
    {
        public IDictionary<string, List<Song>> books { get; set; } = new Dictionary<string, List<Song>>();
    }
}
