using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using API_GUI.Enums;
using Newtonsoft.Json;

namespace API_GUI.API
{
    internal class Characters
    {
        public class Character
        {
            public Info info { get; set; }
            public List<Result> results { get; set; }
        }
        public class Info
        {
            public int count { get; set; }
            public int pages { get; set; }
            public string next { get; set; }
            public object prev { get; set; }
        }
        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }
            public Status status { get; set; }
            public string species { get; set; }
            public string type { get; set; }
            public Gender gender { get; set; }
            public OriginLocation origin { get; set; }
            public ActualLocation location { get; set; }
            public string image { get; set; }
            public List<string> episode { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }

            override public string ToString()
            {
                string s = $"ID: \t\t\t{id}\nName: \t\t\t{name}\nGender: \t\t{gender}\nStatus: \t\t{status}\nSpecies: \t\t{species}\n";
                if(type != "")
                {
                    s += $"Type: \t\t{type}\n";
                }
                s += $"Origin location: \t{origin.name}\nLast known location: \t{location.name}\nEpisode count: \t\t{episode.Count}\n";
                return s;
            }
        }
        public class ActualLocation
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class OriginLocation
        {
            public string name { get; set; }
            public string url { get; set; }
        }



    }

}

        