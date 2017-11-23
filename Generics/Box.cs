using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Box<T> : IBox<T>
    {
        private int count;
        private List<T> items;

        public int Count { get { return count; } }

        public void Add(T Item)
        {
            items.Add(Item);
            count++;
        }
    }
}
