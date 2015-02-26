using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA_Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 237291793913;
            Console.WriteLine(RSAEncrypt(888999000, 202404606, n));
            Console.ReadKey();
        }    
        public static BigInteger RSAEncrypt(BigInteger  P, BigInteger e, BigInteger n)
        {
            return BigInteger.ModPow(P, e, n);
        }
    }


}
