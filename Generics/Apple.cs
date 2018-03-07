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
        private List<T> items = new List<T>();

        public Colour Colour;
        public Apple(Colour colour)
        {
            Colour = colour;
        }

        public int Count {get { return items.Count; } }

        public void Add(T app)
        {
        }
    }
    public enum Colour { Red, Green };
}
