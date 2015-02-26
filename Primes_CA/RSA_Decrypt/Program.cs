using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA_Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 237291793913;
            Console.WriteLine(RSADecrypt(888999000, 202404606, n));
            //Console.WriteLine(RSAEncrypt(202609913015, ))
            Console.ReadKey();
        }    
        public static BigInteger RSADecrypt(BigInteger  C, BigInteger d, BigInteger n)
        {
            return BigInteger.ModPow(C, d, n);
        }
        public static BigInteger RSAEncrypt(BigInteger  P, BigInteger e, BigInteger n)
        {
            return BigInteger.ModPow(P, e, n);
        }
    }
}
