﻿using System;
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
    }
}