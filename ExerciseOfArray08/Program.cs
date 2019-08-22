using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 204, 12, 35 };
            int[] output = HigherWins(a1);
            Console.WriteLine("a1 value:" + output);

            Console.ReadLine();
        }

        public static int[] HigherWins(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            //var temp = numbers[0];
            var first = numbers[0];
            var last = numbers[numbers.Length - 1];

            var highest = 0;
            if (first > last)
            {
                highest = first;
            }
            else
            {
                highest = last;
            }

            for (var i = 0; i < numbers.Length; i++)
            {
                answer[i] = highest;
            }
            //answer[]
            
            return answer;
        }
    }
}
