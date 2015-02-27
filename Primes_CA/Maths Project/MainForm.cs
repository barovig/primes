using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Maths_Project
{
    public partial class MainForm : Form
    {
        // Main Project Functions

        ////////////////////////////////////////////////////////////
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
                    ++i;
            }
            return 1;
        }
        ////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////
        // Prime Factorization Functions
        static List<long> PrimeFactorize(long n)
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

            List<long> result = new List<long>();
            for (long i = 2; i <= n; ++i)           // for each prime
                if (primes[i])
                    result.Add(i);                  //add index (i) which is prime to result List

            return result;
        }
        ////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////
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
        ////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////
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
        ////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////
        // RSA Encryption Function
        public static BigInteger RSAEncrypt(BigInteger P, BigInteger e, BigInteger n)
        {
            return BigInteger.ModPow(P, e, n);
        }
        ////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////
        // RSA Decrypt Function
        public static BigInteger RSADecrypt(BigInteger C, BigInteger d, BigInteger n)
        {
            return BigInteger.ModPow(C, d, n);
        }
        ////////////////////////////////////////////////////////////

        public MainForm()
        {
            InitializeComponent();
        }

        private void q1CheckPrimeBtn_Click(object sender, EventArgs e)
        {
            long inputNum = long.Parse(q1NumEntryTbx.Text);

            if (PrimeCheck(inputNum) == 1)
            {
                q1ResponseLabel.Text = "The number " + inputNum + " is prime";
            }
            else
                q1ResponseLabel.Text = "The number " + inputNum + " is NOT prime";

        }


        private void q1NumEntryTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                long inputNum = long.Parse(q1NumEntryTbx.Text);     // error handling here

                if (PrimeCheck(inputNum) == 1)
                {
                    q1ResponseLabel.Text = "The number " + inputNum + " is prime";
                }
                else
                    q1ResponseLabel.Text = "The number " + inputNum + " is NOT prime";
            }
        }

        private void q2NumEntryTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                long inputNum = long.Parse(q2NumEntryTbx.Text);     // error handling here
                // get list of factors
                List<long> resultList = PrimeFactorize(inputNum);   
                
                string resultString = "";
                // add each number to string
                foreach (var num in resultList)
                    resultString += num.ToString() + "  ";

                q2ResultRTbx.Text = resultString;
            }

        }

        private void q2FactorizeBtn_Click(object sender, EventArgs e)
        {
            long inputNum = long.Parse(q2NumEntryTbx.Text);     // error handling here
            // get list of factors
            List<long> resultList = PrimeFactorize(inputNum);

            string resultString = "";
            // add each number to string
            foreach (var num in resultList)
                resultString += num.ToString() + "  ";

            q2ResultRTbx.Text = resultString;
        }

        private void q3CalcGcdBtn_Click(object sender, EventArgs e)
        {
            long numA = long.Parse(q3EntryATbox.Text);  // error handling
            long numB = long.Parse(q3EntryBTbox.Text);  // -//-

            long gcd = EuclidAlg(numA, numB);

            q3GcdOutLabel.Text = "The Greates Common Divisor of " + numA + " and " + numB + " is " + gcd;
        }

        private void q4Compute_Click(object sender, EventArgs e)
        {
            long numA = long.Parse(q4EntryATbox.Text);  // error handling
            long numB = long.Parse(q4EntryBTbox.Text);  // -//-

            long[] resultArray = ExtEucAlg(numA, numB);

            string equation = string.Format("{0} = {1:+#;-#}a {2:+#;-#;}b", resultArray[0], resultArray[1], resultArray[2]);
            q4EqtnOutTbox.Text = equation;

            string gcd = resultArray[0].ToString();
            string strX = resultArray[1].ToString();
            string strY = resultArray[2].ToString();

            q4GcdOutTbox.Text = gcd;
            q4XOutTbox.Text = strX;
            q4YOutTbox.Text = strY;
        }

        private void q5EncryptBtn_Click(object sender, EventArgs e)
        {
            long msg = long.Parse(q5MsgEntryTbox.Text);    // error handling
            long encExp = long.Parse(q5EncrExpTbox.Text);
            long rsaMod = long.Parse(q5RsaModTbox.Text);

            BigInteger cyphertext = RSAEncrypt(msg, encExp, rsaMod);

            q5CypherTbox.Text = cyphertext.ToString();
        }

        private void q6DecryptBtn_Click(object sender, EventArgs e)
        {
            long cyphertext = long.Parse(q6CypherTbox.Text);
            long decExp = long.Parse(q6DecryptExpTbox.Text);
            long rsaMod = long.Parse(q6RsaModTbox.Text);

            BigInteger message = RSADecrypt(cyphertext, decExp, rsaMod);

            q6PlainTxtTbox.Text = message.ToString();
        }
    }
}
