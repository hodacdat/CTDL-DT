using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Pig : Animal { 
        public override void sound()
        {
            Console.WriteLine("Pig sound");
        }
    }

    class Chicken : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Chicken sound");
        }
    }

    class poliMain
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal b = new Pig();
            Animal c = new Chicken();

            a.sound(); //animal
            b.sound(); //pig
            c.sound(); //chicken
        }
    }
}
