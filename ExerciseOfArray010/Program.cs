using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray010
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = HasEven(new int[] { 2,5 });
            Console.WriteLine("a1 value  " + a1);

            bool a2 = HasEven(new int[] { 4,3 });
            Console.WriteLine("a2 value  " + a2);

            bool a3 = HasEven(new int[] { 7, 5 });
            Console.WriteLine("a3 value  " + a3);

            Console.ReadLine();
        }
        public static bool HasEven(int[] numbers)
        {
            bool ishaseven = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ishaseven = true ;
                }
            }
                return ishaseven;
        }
    }
}
