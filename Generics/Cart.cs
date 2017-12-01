using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Cart : ICountable
    {
        private List<Box> boxes = new List<Box>();

        public int Count { get { return boxes.Sum(x => x.Count); } }

        public void Add(Box box)
        {
            boxes.Add(box);
        }
    }
}
