using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = GetMiddle(new int[] { 1, 2, 3 }, new int[] { 4,5,6});
            Console.WriteLine("a1 value:" + a1);
            Console.ReadLine();
        }
        public static int[] GetMiddle(int[] a, int[] b)
        {
            int[] answer = new int[2];
            int mid1 = a[(a.Length - 1) / 2];
            int mid2 = b[(b.Length - 1 )/ 2];
            answer[0] = mid1;
            answer[1] = mid2;
            return answer;
        }
    }
}
