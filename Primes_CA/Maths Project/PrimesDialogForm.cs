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

    }
}
