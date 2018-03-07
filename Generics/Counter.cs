using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Counter<T>
    {
        private List<T> items = new List<T>();
        private readonly Func<T, bool> IsCountable = a => true;

        public int Count()
        {
            return items.Where(IsCountable).Count();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public Counter(Func<T, bool> toCount)
        {
            IsCountable = toCount;
        }

        public Counter()
        {
        }
    }
}
