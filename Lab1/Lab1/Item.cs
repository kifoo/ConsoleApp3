using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Item
    {
        public int Id { get; set; }
        public double Ratio { get; set; }
        public int Values { get; set; }
        public int Weights { get; set; } 

        public Item(int n, int v, int w)
        {
            Id = n;
            if(v <= 0 && w <= 0)
            {
                Ratio = 0;
                Values = 0;
                Weights = 0;

            }
            else if (v <= 0)
            {
                Ratio = 0;
                Values = 0;
            }
            else if(w <= 0)
            {
                Ratio = 0;
                Weights = 0;
            }
            else
            {
                Ratio = (double)v / w;
                Values = v;
                Weights = w;
            }
        }

        public override string ToString()
        {
            return "no.: " + Id + "\t value: " + Values + "  \t weigth: " + Weights + "\n";
        }


    }
}
