using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list = PrimeCheck(922337203685477);
            foreach(var num in list)
                Console.Write(num+" ");

            Console.ReadKey();
        }

        static List<long> PrimeCheck(long n)
        {
            List<long> list = new List<long>(); 
            int sqrt = (int)Math.Floor(Math.Sqrt((n))); // calculate boundary (sqrt)

            List<long> primesList = GetPrimes(sqrt);    // get the list of all primes between 2 adnd sqrt(n)

            foreach (var k in primesList)               // test each prime
            {
                if(n % k == 0)                          // if it's a factor
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
        static List<long> GetPrimes(long n)
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
            
            List<long> result =  new List<long>();        
            for (long i = 2; i <= n; ++i)           // for each prime
                if (primes[i])
                    result.Add(i);                  //add index (i) which is prime to result List

            return result;
        }
    }
}
