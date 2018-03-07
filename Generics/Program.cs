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
            Apple apple1 = new Apple(Colour.Green);
            Apple apple2 = new Apple(Colour.Red);
            Apple apple3 = new Apple(Colour.Green);

            var appleCounter = new Counter<Apple>();
            var redAppleCounter = new Counter<Apple>(a => a.Colour.Equals(Colour.Red));

            appleCounter.Add(apple1);
            appleCounter.Add(apple2);
            appleCounter.Add(apple3);
           
            redAppleCounter.Add(apple1);
            redAppleCounter.Add(apple2);
            redAppleCounter.Add(apple3);            

            Console.WriteLine("Apple Count {0}", appleCounter.Count());
            Console.WriteLine("Red Apple Count {0}", redAppleCounter.Count());

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
