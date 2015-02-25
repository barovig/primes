using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedEuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

           long[] result =  ExtEucAlg(8359,4962);
           foreach (var e in result)
               Console.WriteLine(e);

           Console.ReadKey();

        }
        public static long[] ExtEucAlg(long a, long b)
        {
            // housekeeping arrays
            Vector3 U = new Vector3(a, 1, 0);
            Vector3 V = new Vector3(b ,0 , 1);

            while (V.a0 > 0)
            {
                long quot = U.a0 / V.a0;
                Vector3 temp = U - (long)Math.Floor((double)U.a0 / V.a0)*V;
                U = V;
                V = temp;
            }

            return U.ToLongArray();
        }
    }
}
