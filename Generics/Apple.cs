using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Apple : ICountable
    {
        public colour color;

        public int Count {get { return 1; } }

        public void Add(T app)
        {
        }
    }
    public enum colour { red, green };
}
