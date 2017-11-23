using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface ICart<T> : ICountable<T>
        {
        void Add(T IBox);
        }
    }
}
