using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Counter : ICountable<T>
    {
        int count;

        void Add(T item);

        public int Count()
        {
            return count;
        }
    }
}
