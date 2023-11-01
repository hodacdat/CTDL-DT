using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class Fibonaci
    {
        public static int Fibo(int limit, int num1, int num2)
        {
            int sum = num1 + num2;

            while (sum < limit)
            {
                Console.Write(sum + " ");
                return Fibo(limit, num2, sum);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("0 1 ");
            Fibo(1000, 0, 1);
        }
    }
}
