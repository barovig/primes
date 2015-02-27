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

           long[] result =  ExtEucAlg(49,191917171313);
           foreach (var e in result)
               Console.WriteLine(e);

           Console.ReadKey();

        }
        /// <summary>
        /// Returns an array of long-s in which first element is GCD(a,b), second and third are 
        /// coefficients x and y in equation GCD(a,b) = x*a + y*b
        /// </summary>
        /// <param name="a">First number used by Euclidean Alg</param>
        /// <param name="b">Second number</param>
        /// <returns>Array of longs containing GCD(a,b); and coefficients</returns>
        public static long[] ExtEucAlg(long a, long b)
        {
            // housekeeping arrays. declared using small 3-vector class suitable for our calculation
            Vector3 U = new Vector3(a, 1, 0);
            Vector3 V = new Vector3(b ,0 , 1);

            while (V.a0 > 0)        // while the first component of V is > 0
            {
                Vector3 temp = U - (long)Math.Floor((double)U.a0 / V.a0)*V;     //process vectors
                U = V;
                V = temp;
            }

            return U.ToLongArray();     // cast vector into long[] array that is returned.
        }
    }
}
