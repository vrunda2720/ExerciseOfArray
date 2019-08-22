using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray012
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = Double23(new int[] { 2, 2, 3 });
            Console.WriteLine("a1 value  " + a1);

            bool a2 = Double23(new int[] { 3, 4, 5, 3 });
            Console.WriteLine("a2 value  " + a2);

            bool a3 = Double23(new int[] { 2, 3, 2, 2 });
            Console.WriteLine("a3 value  " + a3);
            Console.ReadLine();
        }
        public static bool Double23(int[] numbers)
        {
            bool isdouble23 = false;
            
            var temp = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (temp == numbers[i])
                {
                    if (isdouble23 == true)
                    {
                        isdouble23 = false;
                    }
                    else
                    {
                        isdouble23 = true;
                    }
                }
            }
            return isdouble23;
        }
    }
}
