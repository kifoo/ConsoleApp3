using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI.Elements
{
    internal class ElementsList<T> : IEnumerable<T> where T : class
    {
        public Info info { get; set; }
        public List<T> Results { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            return Results.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Results).GetEnumerator();
        }

        override public string ToString()
        {
            string s = "";
            if (Results.Count > 0)
            {
                foreach (T item in Results)
                {
                    s += $"{item}\n";
                }
                return s;
            }
            else
            {
                return "No characters found.";
            }
        }

    }
    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public object prev { get; set; }
    }
}
