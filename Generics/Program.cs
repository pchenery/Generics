using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apples = new Apple();
            Console.WriteLine("Apple Count {0}", apples.Count);

            Box box = new Box();
            T t1 = new T();
            T t2 = new T();
            box.Add(t1);
            box.Add(t2);

            Console.WriteLine("Box contains {0}", box.Count);
            
            Console.ReadLine();
        }
    }
}
