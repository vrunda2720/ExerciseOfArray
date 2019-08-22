using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3 };
            int[] output = Reverse(a1);
            Console.WriteLine("a1 value:" + output);
            Console.ReadLine();
        }

        public static int[] Reverse(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            int temp;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {

                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            answer = numbers;

            return answer;
        }
    }
}
