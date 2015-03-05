using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Project
{
    public partial class RSADialogForm : Form
    {
        public RSADialogForm()
        {
            InitializeComponent();
        }
        public RSADialogForm(MainForm form)
        {
            InitializeComponent();
            this.parentForm = form;
        }
        private readonly MainForm parentForm;

        private void RSACancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RSAGenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long p = long.Parse(EnterPTbox.Text);   /// ERROR HANDLING HERE
                long q = long.Parse(EnterQTbox.Text);
                long exp;

                // if forgot to input encryption exponent, generate it
                if (EnterETbox.Text == "")
                {
                    exp = GenerateE(p, q);
                    EnterETbox.Text = exp.ToString();
                }
                else
                    exp = long.Parse(EnterETbox.Text);

                long[] keys = MathsProcessor.GenerateKeys(p, q, exp);

                OutputNTbox.Text = keys[0].ToString();
                OutputPhiTbox.Text = keys[1].ToString();
                OutputDTbox.Text = keys[2].ToString();

                parentForm.EncryptionExponent = exp.ToString();
                parentForm.Q5RsaModulus = keys[0].ToString();
                parentForm.Q6RsaModulus = keys[0].ToString();
                parentForm.DecryptionExponent = keys[2].ToString();
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

        private void GenerateEBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // get p and q
                long p = long.Parse(EnterPTbox.Text);   // ERROR HANDLING
                long q = long.Parse(EnterQTbox.Text);

                long exponent = GenerateE(p, q);

                EnterETbox.Text = exponent.ToString();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Wrong or missing input. Enter correct values of p and q");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Entered number(s) is too big.");
            }
        }

        private static long GenerateE(long p, long q)
        {
            //calculate Ф(p,q)
            long phi = (p - 1) * (q - 1);

            // start at p-2
            long candidateE = p - 2;
            while (MathsProcessor.EuclidAlg(candidateE, phi) != 1 && MathsProcessor.PrimeCheck(candidateE) != 1)
            {
                --candidateE;
            }

            return candidateE;
        }

        private void EnterQTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                RSAGenerateBtn_Click(sender, e);

        }

        private void EnterETbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                RSAGenerateBtn_Click(sender, e);
        }
    }
}
