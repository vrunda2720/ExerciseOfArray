using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray013
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = Fix23(new int[] { 1, 2, 3 });
            Console.WriteLine("a1 value:" + a1);

            int[] a2 = Fix23(new int[] { 2, 3, 5 });
            Console.WriteLine("a2 value:" + a2);

            int[] a3 = Fix23(new int[] { 1, 2, 1 });
            Console.WriteLine("a3 value:" + a3);

            Console.ReadLine();
        }
        public static int[] Fix23(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 & numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            answer= numbers;

            return answer;
        }
    }
}
