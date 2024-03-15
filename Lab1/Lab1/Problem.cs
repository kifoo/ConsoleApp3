using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace Lab1
{
    internal class Problem
    {
        public int n;
        public List<Item> items = [];
        public List<Item> Result_List = [];
        public Result Result_obj;

        public Problem(int n, int seed = 1)
        {
            this.n = n;
            Random random = new Random(seed);
            for (int i = 0; i< n; i++)
            {
                Item new_item = new(i, random.Next(10) + 1, random.Next(10) + 1);
                items.Add(new_item);
                Console.WriteLine("no.: "  + i + "\t v: " + items[i].Values + "\t w: " + new_item.Weights);
            }

        }

        public void Solve(int capacity)
        {
            if (capacity < 0)
                capacity = 0;

            List<Item> Sorted_list =  items.OrderBy(o => o.Ratio).ToList();
            Sorted_list.Reverse();
            items = Sorted_list;
            int tw = 0;
            int tv = 0;

            foreach (Item item in items)
            {
                if (capacity - item.Weights >= 0)
                {
                    Result_List.Add(item);
                    tw += item.Weights;
                    tv += item.Values;
                    capacity -= item.Weights;
                }
                else
                    break;
            }
            Result_obj = new Result(tw, tv, Result_List);
            Console.WriteLine(Result_obj);
        }

        public override string ToString()
        {
            string res = "";
            foreach (Item item in items)
            {
                res += item.ToString();
            }
            return res;
        }
    }

}

