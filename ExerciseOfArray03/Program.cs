using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = MakePi(3);
            Console.WriteLine("a1 value:" + a1);

            Console.ReadLine();
        }

        public static int[] MakePi(int n)
        {
            int[] pi = new int[] { 3, 1, 4, 2, 8, 5, 7, 1, 4, 2 };
            int[] answer = new int[n];

            for(int i=0; i<= n-1; i++)
            {
                answer[i] = pi[i];
            }
            
            return answer;
        }
    }
}
