using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Apple : ICountable<T>
    {
        private int count = 1;

        public int Count()
        {
            return count;
        }
    }
}
