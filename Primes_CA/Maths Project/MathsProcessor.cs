using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Maths_Project
{
    /// <summary>
    /// This class contains mathematical functions used throughout entire project
    /// </summary>
    class MathsProcessor
    { 
        // Prime Check Function
        public static int PrimeCheck(long n)
        {
            // calculate square root estimate
            int sqrt = (int)Math.Floor(Math.Sqrt((n)));
            for (int i = 2; i <= sqrt; i += 2)
            {

                if (n % i == 0) // factor found
                    return 0;
                if (i == 2) // increment i to make it odd on the first iteration
                {
                    ++i;
                    if (n % i == 0)  // test i = 3
                        return 0;
                }
            }
            return 1;
        }

        // Prime Factorization Functions
        public static List<long> PrimeFactorize(long n)
        {
            List<long> list = new List<long>();
            int sqrt = (int)Math.Floor(Math.Sqrt((n))); // calculate boundary (sqrt)

            List<long> primesList = GetPrimes(sqrt);    // get the list of all primes between 2 adnd sqrt(n)

            foreach (var k in primesList)               // test each prime
            {
                if (n % k == 0)                          // if it's a factor
                {
                    long newN = n;
                    while (newN % k == 0)               // while n can be divided into k
                    {
                        list.Add(k);                    // add k to list of factors
                        newN /= k;                      // reduce n by k
                    }
                }
            }
            long checkNum = 1;
            foreach (var num in list)       // test each prime factor found
                checkNum *= num;            // multiply them together
            if (checkNum != n)              // if product of factors not equal to n, we're missing a single factor that is > sqrt(n)
                list.Add(n / checkNum);     // find this factor and add to our list

            return list;
        }

        /// <summary>
        /// Implements Sieve of Erathosthenes to get all prime numbers
        /// between 2 and n
        /// </summary>
        /// <param name="n">Upper bound for list</param>
        /// <returns>List&#60;jlong&#62; of all primes between 2 and n</returns>
        public static List<long> GetPrimes(long n)
        {
            bool[] primes = new bool[n + 1];    // create array of bools. if bool at index 'i' is true, then 'i' is prime
            for (long i = 2; i <= n; i++)
                primes[i] = true;               // initialize them all to true

            for (long i = 2; i <= n; i++)       // start at i = 2
            {
                if (primes[i])                  // if its prime
                {
                    // go through whole array
                    for (long j = i * 2; j <= n; j += i)    // start with the first multiple(i.e. multiple of 2) and proceed in steps of i (which is prime)
                        primes[j] = false;                  // set them to false (not prime)
                }
            }

            List<long> result = new List<long>();
            for (long i = 2; i <= n; ++i)           // for each prime
                if (primes[i])
                    result.Add(i);                  //add index (i) which is prime to result List

            return result;
        }

        // Euclidean Algorithm Function
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
        public static void swap(ref long a, ref long b)     // little helper func
        {
            long temp = a;
            a = b;
            b = temp;
        }

        // Extended Euclidean Algorithm Functions
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
            Vector3 V = new Vector3(b, 0, 1);

            while (V.a0 > 0)        // while the first component of V is > 0
            {
                Vector3 temp = U - (long)Math.Floor((double)U.a0 / V.a0) * V;     //process vectors
                U = V;
                V = temp;
            }

            return U.ToLongArray();     // cast vector into long[] array that is returned.
        }

        // RSA Encryption Function
        public static BigInteger RSAEncrypt(BigInteger P, BigInteger e, BigInteger n)
        {
            return BigInteger.ModPow(P, e, n);
        }

        // RSA Decrypt Function
        public static BigInteger RSADecrypt(BigInteger C, BigInteger d, BigInteger n)
        {
            return BigInteger.ModPow(C, d, n);
        }
       
        // Generate RSA Keys function
        public static long[] GenerateKeys(long p, long q, long e)
        {
            long[] result = new long[3];
            long phi, n, d;
            // calculate n and phi
            n = p * q;
            phi = (p - 1) * (q - 1);

            long[] euclidOutput = new long[3];
            // find d using extended Euclidean algorithm
            euclidOutput = MathsProcessor.ExtEucAlg(e, phi);
            d = euclidOutput[1];

            // set results to array
            result[0] = n;
            result[1] = phi;
            result[2] = d;

            // If d is negative it's not suitable, therefore add phi. This will change value of v
            // however the equation d*e - v*Ф = 1 will still hold
            if (d < 0)
                result[2] += phi;

            return result;
        }
    }
}
