using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1=SameFirstLast(new int[]{ 1,2,3});
            Console.WriteLine("a1 value:" + a1);

            bool a2 = SameFirstLast(new int[] { 1, 2, 3,1});
            Console.WriteLine("a2 value:" + a2);

            bool a3 = SameFirstLast(new int[] { 1, 2, 1 });
            Console.WriteLine("a3 value:" + a3);


            Console.ReadLine();
        }

        public static bool SameFirstLast(int[] numbers)
        {
            bool isSameFirstLast = false;

            int length = numbers.Length;
            int Lastnumber = length - 1;

            if ((numbers[0] == numbers[Lastnumber])&& (length>=1))
                return true;

            return isSameFirstLast;
        }
    }
}
