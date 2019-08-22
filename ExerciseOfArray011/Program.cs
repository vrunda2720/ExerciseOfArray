using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray011
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] output = KeepLast(new int[]{3}); 
        }

        public static int[] KeepLast(int[] numbers)
        {
            int length = numbers.Length; //3
            int[] answer = new int[length * 2]; //6
            var temp = numbers[numbers.Length - 1]; //6

            for(int i=0; i<=answer.Length-1;i++)
            {
                answer[i] = 0;
                if(i==answer.Length-1)
                {
                    answer[i] = temp;
                }
            }
            return answer;

        }
    }
}
