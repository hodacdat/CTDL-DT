using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class RandomNumber
    {
        public static int[] random(int min, int max, int count)
        {
            if (min > max || max - min < count)
            {
                throw new ArgumentException("Invalid");
            }

            Random r = new Random();
            HashSet<int> s = new HashSet<int>();

            while (s.Count < count)
            {
                int randomNum = r.Next(min, max + 1);
                s.Add(randomNum);
            }
            int[] numberArray = new int[s.Count];
            s.CopyTo(numberArray);

            return numberArray;
        }

        public static int[] findMissingNumber(int[] Arraynumbers, int min, int max, int countRemain)
        {
            List<int> Missingnumbers = new List<int>();
            for (int i = min; i < max; i++)
            {
                if (!checkContain(Arraynumbers, i))
                {
                    Missingnumbers.Add(i);

                    if (Missingnumbers.Count == countRemain)
                    {
                        break;
                    }
                }
            }
            return Missingnumbers.ToArray();
        }

        public static bool checkContain(int[] arrayNum, int number)
        {

            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (number == arrayNum[i])
                {

                    return true;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            int[] array = new int[95];

            array = random(1, 100, 95);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int[] missing = new int[5];

            missing = findMissingNumber(array, 1, 100, 5);

            for (int i = 0; i < missing.Length; i++)
            {
                Console.Write(missing[i] + " ");
            }
        }
    }
}
