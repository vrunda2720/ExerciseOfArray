using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3 };
            int[] output = RotateLeft(a1);
            Console.WriteLine("a1 value:" + output);

            int[] a2 = { 5,11,9};
            int[] output1 = RotateLeft(a2);
            Console.WriteLine("a2 value:" + output1);

            int[] a3 = { 7,0,0 };
            int[] output2= RotateLeft(a3);
            Console.WriteLine("a3 value:" + output2);

            Console.ReadLine();
        }

        public static int[] RotateLeft(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            var temp = numbers[0];
            
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                answer[i] = numbers[i + 1];
            }
            answer[numbers.Length - 1] = temp;

            return answer;
        }
    }
}
