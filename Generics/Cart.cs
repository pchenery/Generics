using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Cart : ICountable
    {
        private readonly List<Box> boxes = new List<Box>();

        public int Count { get { return boxes.Sum(x => x.Count); } }

        public void Add(Box box)
        {
            boxes.Add(box);
        }
    }
}
