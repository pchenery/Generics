using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Cart<Box> : ICart<Box>
    {
        private int count;
        private List<Box> boxes;

        public int Count { get { return count; } }
        public void Add(Box box)
        {
            boxes.Add(box);
            count++;
        }
    }
}
