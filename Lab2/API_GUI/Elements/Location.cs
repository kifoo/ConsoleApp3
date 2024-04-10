using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI.Elements
{
    internal class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimension { get; set; }
        public List<string> Residents { get; set; }
        public string URL { get; set; }

        override public string ToString()
        {
            string s = $"Name: {Name}\nType: {Type}\nDimension: {Dimension}\nResidents:\n";
            foreach (string resident in Residents)
            {
                s += $"{resident}\n";
            }
            return s;
        }
    }
}
