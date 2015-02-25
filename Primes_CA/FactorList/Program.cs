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
            List<long> list = PrimeCheck(100);
            foreach(var num in list)
                Console.Write(num+" ");

            Console.ReadKey();
        }
        static List<long> PrimeCheck(long n)
        {
            List<long> list = new List<long>();
            List<long> primesList = GetPrimes(n);

            int sqrt = (int)Math.Floor(Math.Sqrt((n)));
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

            return list;
        }

        static List<long> GetPrimes(long n)
        {
            return new List<long>();        // this function will get all prime numbers from 2 to n using sieve
        }
    }
}
