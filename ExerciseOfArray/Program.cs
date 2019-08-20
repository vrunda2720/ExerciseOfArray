using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = FirstLast6(new int[] { 1, 2 ,6});
            Console.WriteLine("a1 value  " + a1);

            bool a2 = FirstLast6(new int[] { 6,1,2,3 });
            Console.WriteLine("a2 value  " + a2);

            bool a3 = FirstLast6(new int[] { 13, 6,1, 2, 3 });
            Console.WriteLine("a3 value  " + a3);

            bool a4 = FirstLast6(new int[] { 13, 2, 1, 2, 3 });
            Console.WriteLine("a4 value  " + a4);
            Console.ReadLine();


        }

        public static bool FirstLast6(int[] numbers)
        {
            bool isFistLast6 = false;

            int length = numbers.Length;
            int lastnumber = length - 1;

            if (numbers[0] == 6)
                isFistLast6 = true;

            if (numbers[lastnumber] == 6)
                isFistLast6 = true;

            
            return isFistLast6;
        }
    }
}
