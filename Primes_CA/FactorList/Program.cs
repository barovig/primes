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
            int sqrt = (int)Math.Floor(Math.Sqrt((n)));

            List<long> primesList = GetPrimes(sqrt);

            foreach (var k in primesList)
            {
                if(n % k == 0)
                {
                    long newN = n;
                    while (newN % k == 0)
                    {
                        list.Add(k);
                        newN /= k;
                    }
                }
            }

            long checkNum = 1;
            foreach (var num in list)
                checkNum *= num;
            if (checkNum != n)
                list.Add(n / checkNum);


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
            bool[] primes = new bool[n + 1];    // create arrat of bools. if bool at index 'i' is true, then 'i' is prime
            for (long i = 2; i <= n; i++) 
                primes[i] = true;               // initialize them all to true

            for (long i = 2; i <= n; i++)       // start at i = 2, i.e. the first prime.
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
