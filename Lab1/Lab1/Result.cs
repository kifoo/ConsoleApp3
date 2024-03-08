using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Result(int tw, int tv, List<Item> r)
    {
        public int Total_weight { get; set; } = tw;
        public int Total_value { get; set; } = tv;

        public List<Item> result = r;

        public override string ToString()
        {
            string res =  "Total value: " + Total_value + "\nTotal weight: " + Total_weight + "\nItems: ";
            for(int i = 0; i < result.Count; i++)
            {
                res += result[i].Id + ", " ;
            }
            return res;
        }
    }
}
