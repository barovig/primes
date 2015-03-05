using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Maths_Project
{
    public partial class PrimesDialogForm : Form
    {
        public PrimesDialogForm()
        {
            InitializeComponent();
        }
        public PrimesDialogForm(string actionButtonText)
        {
            InitializeComponent();
            q1CheckNumsBtn.Text = actionButtonText;
        }

        private void q1CloseDialogBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void q1CheckNumsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if it is q1 button by checking test
                if (q1CheckNumsBtn.Text == "Check Numbers")
                    PrimeCheckNums();
                else
                    PrimeFactorizeNums();
                MessageBox.Show("Done!...");
                this.Close();

            }
            catch(FormatException formatExcptn)
            {
                MessageBox.Show("Wrong or missing input. Enter numbers separated by spaces");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }

        }

        private void PrimeCheckNums()
        {
            List<long> numsList = GetNumsFromTbox();

            using (StreamWriter sw = new StreamWriter(@"Q1.txt"))        // modify file paths later
            {
                sw.WriteLine("Q1.\n");

                foreach (var num in numsList)
                {
                    if (MathsProcessor.PrimeCheck(num) == 1)
                        sw.WriteLine("The number {0} is prime", num);
                    else
                        sw.WriteLine("The number {0} is NOT prime", num);
                }
            }
        }
        private void PrimeFactorizeNums()
        {
            List<long> numsList = GetNumsFromTbox();
            using (StreamWriter sw = new StreamWriter(@"Q2.txt"))        // modify file paths later
            {
                sw.WriteLine("Q2.\n");

                foreach (var num in numsList)
                {
                    List<long> factorList = MathsProcessor.PrimeFactorize(num);
                    sw.Write("The factors of {0} are: ", num);
                    foreach(var factor in factorList)
                    {
                        sw.Write(factor + " ");
                    }
                    sw.Write("\n");
                }
            } 
        }

        private List<long> GetNumsFromTbox()
        {
            // split string in textbox by space and populate an array
            string[] numsString = q1InsertNumsTbox.Text.Trim().Split(' ');
            // create empty list
            List<long> numsList = new List<long>();
            // populate list by trying parsing strings from array
            foreach (var num in numsString)
                numsList.Add(long.Parse(num));      // ERROR HANDLING HERE

            return numsList;

        }

        private void q1InsertNumsTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                q1CheckNumsBtn_Click(sender, e);
        }
    }
}
