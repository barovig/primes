using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} is {1}", 30, Convert.ToBoolean(PrimeCheck(30)) ? "prime" : "not prime");
            Console.WriteLine("{0} is {1}", 31, Convert.ToBoolean(PrimeCheck(31)) ? "prime" : "not prime");
            Console.WriteLine("{0} is {1}", 487, Convert.ToBoolean(PrimeCheck(487)) ? "prime" : "not prime");
            Console.WriteLine("{0} is {1}", 8893, Convert.ToBoolean(PrimeCheck(8893)) ? "prime" : "not prime");
            Console.WriteLine("{0} is {1}", 987654323, Convert.ToBoolean(PrimeCheck(987654323)) ? "prime" : "not prime");
            Console.WriteLine("{0} is {1}", 131317171919, Convert.ToBoolean(PrimeCheck(131317171919)) ? "prime" : "not prime");

            Console.Read();
        }

        public static int PrimeCheck(long n)
        {
            // calculate square root estimate
            int sqrt = (int)Math.Floor(Math.Sqrt((n)));
            for (int i = 2; i <= sqrt; ++i)
            {
                if (n % i == 0) // factor found
                    return 0;
            }
            return 1;
        }
    }
}
