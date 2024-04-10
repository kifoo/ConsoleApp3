using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI.Elements
{
    internal class Episode
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("air_date")]
        public string AirDate { get; set; }
        [JsonProperty("episode")]
        public string EpisodeCode { get; set; }
        public List<string> Characters { get; set; }
        public string URL { get; set; }
        public string Created { get; set; }
        public DateTime DateCreated => DateTime.Parse(Created);
        public DateTime AirDateTime => DateTime.Parse(AirDate);

        override public string ToString()
        {
            string s = $"Name: {Name}\nAir Date: {AirDate}\nCreated: {Created}\nCharacters:\n";
            foreach (string character in Characters)
            {
                s += $"{character}\n";
            }
            return s;
        }
    }
}
