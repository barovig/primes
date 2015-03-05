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
using System.IO;
using System.Reflection;

namespace Maths_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // get text for Help section from embedded ReadMe.txt file
            using(Stream strm = Assembly.GetExecutingAssembly().GetManifestResourceStream("Maths_Project.ReadMe.txt"))
            using(StreamReader sr = new StreamReader(strm))
            {
                string help = sr.ReadToEnd().ToString();
                helpTbox.Text = help;
            }

        }

        // properties for RSA Encrypt/Decrypt to allow set/get values from RSA GenerateKeys
        public string EncryptionExponent
        {
            set { q5EncrExpTbox.Text = value; }
        }
        public string Q5RsaModulus
        {
            set { q5RsaModTbox.Text = value; }
        }
        public string DecryptionExponent
        {
            set { q6DecryptExpTbox.Text = value; }
        }
        public string Q6RsaModulus
        {
            set { q6RsaModTbox.Text = value; }
        }

        private void q1CheckPrimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long inputNum = long.Parse(q1NumEntryTbx.Text);

                if (MathsProcessor.PrimeCheck(inputNum) == 1)
                {
                    q1ResponseLabel.Text = "The number " + inputNum + " is prime";
                }
                else
                    q1ResponseLabel.Text = "The number " + inputNum + " is NOT prime";
            }
            catch (FormatException formatExcptn)
            {
                MessageBox.Show("Wrong number format. Please enter a correct number.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }



        }


        private void q1NumEntryTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                q1CheckPrimeBtn_Click(sender, e);
            }
        }

        private void q2NumEntryTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                q2FactorizeBtn_Click(sender, e);
            }

        }

        private void q2FactorizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long inputNum = long.Parse(q2NumEntryTbx.Text);     // error handling here
                // get list of factors
                List<long> resultList = MathsProcessor.PrimeFactorize(inputNum);

                string resultString = "";
                // add each number to string
                foreach (var num in resultList)
                    resultString += num.ToString() + "  ";

                q2ResultRTbx.Text = resultString;
            }
            catch (FormatException frmtExcptn)
            {
                MessageBox.Show("Wrong number format. Please enter a correct number.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }
        }

        private void q3CalcGcdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long numA = long.Parse(q3EntryATbox.Text);  // error handling
                long numB = long.Parse(q3EntryBTbox.Text);  // -//-

                long gcd = MathsProcessor.EuclidAlg(numA, numB);

                q3GcdOutLabel.Text = "The Greatest Common Divisor of " + numA + " and " + numB + " is " + gcd;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Wrong or missing input. Please enter a and b in a correct format.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }
        }

        private void q4Compute_Click(object sender, EventArgs e)
        {
            try
            {
                long numA = long.Parse(q4EntryATbox.Text);  // error handling
                long numB = long.Parse(q4EntryBTbox.Text);  // -//-

                long[] resultArray = MathsProcessor.ExtEucAlg(numA, numB);

                string equation = string.Format("{0} = {1:+#;-#}a {2:+#;-#;}b", resultArray[0], resultArray[1], resultArray[2]);
                q4EqtnOutTbox.Text = equation;

                string gcd = resultArray[0].ToString();
                string strX = resultArray[1].ToString();
                string strY = resultArray[2].ToString();

                q4GcdOutTbox.Text = gcd;
                q4XOutTbox.Text = strX;
                q4YOutTbox.Text = strY;
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Wrong or missing input. Please enter a and b in a correct format.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }

        }

        private void q5EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long msg = long.Parse(q5MsgEntryTbox.Text);    // error handling
                long encExp = long.Parse(q5EncrExpTbox.Text);
                long rsaMod = long.Parse(q5RsaModTbox.Text);

                BigInteger cyphertext = MathsProcessor.RSAEncrypt(msg, encExp, rsaMod);

                q5CypherTbox.Text = cyphertext.ToString();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Wrong or missing input. Please fill all input fields in a correct number format.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }
        }

        private void q6DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long cyphertext = long.Parse(q6CypherTbox.Text);
                long decExp = long.Parse(q6DecryptExpTbox.Text);
                long rsaMod = long.Parse(q6RsaModTbox.Text);

                BigInteger message = MathsProcessor.RSADecrypt(cyphertext, decExp, rsaMod);

                q6PlainTxtTbox.Text = message.ToString();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Wrong or missing input. Please fill all input fields in a correct number format.");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }
        }

        private void q1CheckMultipleBtn_Click(object sender, EventArgs e)
        {
            PrimesDialogForm q1checkMultipleDialog = new PrimesDialogForm();
            q1checkMultipleDialog.ShowDialog();
        }

        private void q2FactorizeMultpBtn_Click(object sender, EventArgs e)
        {
            PrimesDialogForm q2checkMultipleDialog = new PrimesDialogForm(@"Factorize");
            q2checkMultipleDialog.ShowDialog();
        }

        private void q3ComputeMultBtn_Click(object sender, EventArgs e)
        {
            EuclideanAlgDialog q3ComputeMultDialog = new EuclideanAlgDialog();
            // set QuestionNumber property to 3
            q3ComputeMultDialog.QuestionNumber = "3";

            // add default values to the list
            List<long[]> q3Nums = new List<long[]>();

            q3Nums.Add(new long[2] { 525, 223 });
            q3Nums.Add(new long[2] { 12364, 9867});
            q3Nums.Add(new long[2] { 1234567890, 0987654321 });
            q3Nums.Add(new long[2] { 13131717191919, 191917171313 });

            // set dialog's internal list to added nums
            q3ComputeMultDialog.PairList = q3Nums;
            // show dialog
            q3ComputeMultDialog.ShowDialog();
        }

        private void q4ComputeMultBtn_Click(object sender, EventArgs e)
        {
            EuclideanAlgDialog q4ComputeMultDialog = new EuclideanAlgDialog();
            q4ComputeMultDialog.QuestionNumber = "4";

            // add default values to the list
            List<long[]> q4Nums = new List<long[]>();

            q4Nums.Add(new long[2] { 8359, 4962});
            q4Nums.Add(new long[2] { 95243, 24138 });
            q4Nums.Add(new long[2] { 88243, 16947 });

            // set dialog's internal list to added nums
            q4ComputeMultDialog.PairList = q4Nums;
            // show dialog
            q4ComputeMultDialog.ShowDialog();
        }

        private void q5GenerateKeysBtn_Click(object sender, EventArgs e)
        {
            RSADialogForm generateKeysDialog = new RSADialogForm(this);
            generateKeysDialog.Show();
        }

        private void q6GenerateKeysBtn_Click(object sender, EventArgs e)
        {
            RSADialogForm generateKeysDialog = new RSADialogForm(this);
            generateKeysDialog.Show();
        }

        private void q3EntryBTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q3CalcGcdBtn_Click(sender, e);
        }

        private void q4EntryBTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q4Compute_Click(sender, e);
        }

        private void q5RsaModTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q5EncryptBtn_Click(sender, e);
        }

        private void q6RsaModTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q6DecryptBtn_Click(sender, e);
        }

        private void q3EntryATbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q3CalcGcdBtn_Click(sender, e);
        }

        private void q4EntryATbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q4Compute_Click(sender, e);
        }

        private void q5MsgEntryTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q5EncryptBtn_Click(sender, e);
        }

        private void q5EncrExpTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q5EncryptBtn_Click(sender, e);
        }

        private void q6CypherTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q6DecryptBtn_Click(sender, e);
        }

        private void q6DecryptExpTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q6DecryptBtn_Click(sender, e);
        }

        private void HelpGenerateReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            using(StreamWriter sw = new StreamWriter(@"Report.txt"))
            {
                sw.WriteLine("This is an automatically generated report file containing answers for questions 1 to 4.\n\n");
                try
                {
                    using (StreamReader sr = new StreamReader("Q1.txt"))
                    {
                        string q1 = sr.ReadToEnd();
                        sw.WriteLine(q1);
                    }
                }
                catch(Exception e){}
                try
                {
                    using (StreamReader sr = new StreamReader("Q2.txt"))
                    {
                        string q2 = sr.ReadToEnd();
                        sw.WriteLine(q2);
                    } 
                }
                catch (Exception e) { }

                try
                {
                    using (StreamReader sr = new StreamReader("Q3.txt"))
                    {
                        string q3 = sr.ReadToEnd();
                        sw.WriteLine(q3);
                    }
                }
                catch (Exception e) { }

                try
                {
                    using (StreamReader sr = new StreamReader("Q4.txt"))
                    {
                        string q4 = sr.ReadToEnd();
                        sw.WriteLine(q4);
                    }
                }
                catch (Exception e) { }

                MessageBox.Show("Done!");
                sw.WriteLine("END OF REPORT");

            }
        }

    }
}
