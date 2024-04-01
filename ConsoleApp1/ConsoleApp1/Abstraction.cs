using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Phone
    {
        public void turnOn()
        {
            Console.WriteLine("TUrn on");
        }

        public abstract void typeInput();
    }

    class SmartPhone : Phone
    {
        public override void typeInput()
        {
            Console.WriteLine("Input by touch"); ;
        }
    }

    class T9Phone : Phone
    {
        public override void typeInput()
        {
            Console.WriteLine("Type by press button");
        }
    }

    class abs
    {
        static void Main(string[] args)
        {
            SmartPhone phone = new SmartPhone();
            phone.turnOn();
            phone.typeInput();

            T9Phone t9Phone = new T9Phone();
            t9Phone.typeInput();
            t9Phone.turnOn();
        }
    }
}
