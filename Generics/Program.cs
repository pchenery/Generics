using Generics;
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
            Apple apple1 = new Apple(Colour.green);
            Apple apple2 = new Apple(Colour.red);
            Apple apple3 = new Apple(Colour.green);

            var AppleCounter = new Counter<Apple>();
            var RedAppleCounter = new Counter<Apple>(a => a.color.Equals(Colour.red));

            AppleCounter.Add(apple1);
            AppleCounter.Add(apple2);
            AppleCounter.Add(apple3);
           
            RedAppleCounter.Add(apple1);
            RedAppleCounter.Add(apple2);
            RedAppleCounter.Add(apple3);            

            Console.WriteLine("Apple Count {0}", AppleCounter.Count());
            Console.WriteLine("Red Apple Count {0}", RedAppleCounter.Count());

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
