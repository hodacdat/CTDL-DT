using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        public string brand = "Ford";
        public void horn()
        {
            Console.WriteLine("Tut, tut");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";

    }

    class programInherited
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            c.horn(); // using horn function of Vehicle class
            Console.WriteLine(c.modelName + " " +  c.brand); //Mustang Ford
        }
    }
}
