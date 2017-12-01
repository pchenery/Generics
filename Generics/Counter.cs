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
        private int count;

        int Count { get { return count; } set { count = value; } }

        void Add(T item)
        {
        }
    }
}
