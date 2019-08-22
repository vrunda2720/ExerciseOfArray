using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Sum(new int[] { 1, 2, 3 });
            Console.WriteLine("a1 value:" + a1);

            int a2 = Sum(new int[] { 5,11,2 });
            Console.WriteLine("a2 value:" + a2);

            int a3 = Sum(new int[] { 7,0,0 });
            Console.WriteLine("a3 value:" + a3);

            Console.ReadLine();
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                sum = sum+numbers[i] ;
            }

            return sum;
        }
    }
}
