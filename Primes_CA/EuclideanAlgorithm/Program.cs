using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 524;
            long b = 223;
            long d;
            Console.WriteLine(EuclidAlg(a, b));
            Console.ReadKey();
        }

        public static long EuclidAlg(long a, long b)
        {
            if (a > b)
                swap(ref a, ref b);
            while (a != 0)
            {

                long rem = b % a;
                b = a;
                a = rem;
            }
            return b;
        }

        // little helper func
        public static void swap(ref long a, ref long b)
        {
            long temp = a;
            a = b;
            b = temp;
        }
    }
}
