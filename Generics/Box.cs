using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box : ICountable
    {
        //private int count;
        private List<T> items = new List<T>();

        public int Count { get { return items.Count; } }

        public void Add(T Item)
        {
            items.Add(Item);
            //count++;
        }
    }
}
