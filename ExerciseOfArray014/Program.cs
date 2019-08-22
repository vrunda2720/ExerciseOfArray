using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray014
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = Unlucky1(new int[] { 1, 1, 1 });
            Console.WriteLine("a1 value  " + a1);

            bool a2 = Unlucky1(new int[] { 1, 3, 4, 5 });
            Console.WriteLine("a2 value  " + a2);

            bool a3 = Unlucky1(new int[] { 2, 1, 3, 4, 5 });
            Console.WriteLine("a3 value  " + a3);

            Console.ReadLine();
        }
        public static bool Unlucky1(int[] numbers)
        {
            bool isunlucky = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
              if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    isunlucky = true;
                }

            }
            return isunlucky;
        }
    }
}
