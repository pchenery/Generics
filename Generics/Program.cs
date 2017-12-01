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
            Apple apple = new Apple();
            Console.WriteLine("Apple Count {0}", apple.Count);

            Box box1 = new Box();
            T t1 = new T();
            T t2 = new T();
            box1.Add(t1);
            box1.Add(t2);
            Console.WriteLine("Box1 contains {0} items", box1.Count);

            Box box2 = new Box();
            T t3 = new T();
            T t4 = new T();
            T t5 = new T();
            box2.Add(t3);
            box2.Add(t4);
            box2.Add(t5); ;
            Console.WriteLine("Box2 contains {0} items", box2.Count);

            Cart cart = new Cart();
            cart.Add(box1);
            cart.Add(box2);

            Console.WriteLine("Cart contains {0} items", cart.Count);
            Console.ReadLine();
        }
    }
}
