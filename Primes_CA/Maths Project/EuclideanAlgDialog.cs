using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Project
{
    public partial class EuclideanAlgDialog : Form
    {
        public EuclideanAlgDialog()
        {
            InitializeComponent();          
        }

        private void EuclidDialogCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // a flag-like property to specify which question form relates to
        private string questionNum;
        public string QuestionNumber
        { set { questionNum = value; } get { return questionNum; } }

        // list of pairs (a,b)
        private List<long[]> pairList = new List<long[]>();
        public List<long[]> PairList
        { set { pairList = value; } get { return pairList; } }

        // string showing the list of numbers added
        private string addedNumsString;
        public string AddedNums
        { set { addedNumsString = value; } get { return addedNumsString; } }

        private void AddNumsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long[] nums = new long[2];      // nums[0] = a, nums[1] = b
                nums[0] = long.Parse(EntryATbox.Text);    // ERROR HANDLING HERE
                nums[1] = long.Parse(EntryBTbox.Text);

                PairList.Add(nums); // add array to PairList property
                // clear text boxes
                EntryATbox.Clear();
                EntryBTbox.Clear();
                AddedNums += String.Format("a = {0}, b = {1}\n", nums[0], nums[1]);
                AddedNumsTbox.Text = AddedNums;
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

        private void ComputeAllBtn_Click(object sender, EventArgs e)
        {
            if (QuestionNumber == "3")
            {
                ApplyEuclidAlg();
            }
            else
                ApplyExtendedEuclidAlg();

            // if list is empty. weird construct, but there is no IsEmpty() method for a list
            if (!PairList.Any())
                MessageBox.Show("List is empty.");
            else
            {
                MessageBox.Show("Done!...");
                this.Close();
            }
        }

        private void ApplyExtendedEuclidAlg()
        {
            using (StreamWriter sw = new StreamWriter(@"Q4.txt"))
            {
                sw.WriteLine("Q4.\n");
                foreach (var pair in PairList)
                {
                    // display a and b
                    sw.WriteLine("a = {0}, b = {1}",pair[0], pair[1]);
                    // get gcd, x and y
                    long[] result = MathsProcessor.ExtEucAlg(pair[0], pair[1]);
                    // write an equation. formatters used to show correct sign
                    sw.WriteLine("Equation: {1:+#;-#}a {2:+#;-#;}b = {0}", result[0], result[1], result[2]);
                    // display GCD
                    sw.WriteLine("GCD({0}, {1}) = {2}", pair[0], pair[1], result[0]);
                    // display coefficients
                    sw.WriteLine("x = {0}\ny = {1}\n", result[1], result[2]);

                }
            }
        }

        private void ApplyEuclidAlg()
        {
            using(StreamWriter sw = new StreamWriter(@"Q3.txt"))
            {
                sw.WriteLine("Q3.\n");
                foreach(var pair in PairList)
                {
                    sw.WriteLine("GCD({0}, {1}) = {2}", pair[0], pair[1], MathsProcessor.EuclidAlg(pair[0], pair[1]));
                }
            }
        }

        private void EntryBTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                AddNumsBtn_Click(sender, e);
        }

        private void EntryATbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                AddNumsBtn_Click(sender, e);
        }

        private void EuclidDialogClearAllBtn_Click(object sender, EventArgs e)
        {
            PairList.Clear();
            AddedNums = "";
            AddedNumsTbox.Text = AddedNums;
        }

        private void EuclideanAlgDialog_Shown(object sender, EventArgs e)
        {
            // for each element in PairList
            foreach (var pair in PairList)
            {
                AddedNums += String.Format("a = {0}, b = {1}\n", pair[0], pair[1]);
            }

            AddedNumsTbox.Text = AddedNums;

        }

        
    }
}
