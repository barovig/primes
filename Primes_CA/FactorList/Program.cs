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
            int sqrt = (int)Math.Floor(Math.Sqrt((n)));
            for (long k = 2; k < sqrt; ++k)
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
    }
}
