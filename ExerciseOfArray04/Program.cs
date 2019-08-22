using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfArray04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1=commonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3 });
            Console.WriteLine("a1 value:" + a1);

            bool a2 = commonEnd(new int[] { 1,2,3 }, new int[] { 7, 3 ,2});
            Console.WriteLine("a2 value:" + a2);

            bool a3 = commonEnd(new int[] { 1, 2, 3 }, new int[] { 1, 3 });
            Console.WriteLine("a3 value:" + a3);
            Console.ReadLine();
            
        }

        public static bool commonEnd(int[] a, int[] b)
        {
            bool iscommonEnd = false;
            int length1 = a.Length;
            int length2 = b.Length;
            int Lastnumber1 = length1 - 1;
            int Lastnumber2 = length2 - 1;

            if ((a[0] == b[0]) || (a[Lastnumber1]==b[Lastnumber2]) && (length1>=1) && (length2>=1))
                return true;

            return iscommonEnd;
        }
    }
}
