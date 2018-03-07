using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box : ICountable
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count;}
        }

        public void Add(T item)
        {
            items.Add(item);
        }
    }
}
