namespace Maths_Project
{
    partial class EuclideanAlgDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterALabel = new System.Windows.Forms.Label();
            this.EnterBLabel = new System.Windows.Forms.Label();
            this.EntryATbox = new System.Windows.Forms.TextBox();
            this.EntryBTbox = new System.Windows.Forms.TextBox();
            this.AddNumsBtn = new System.Windows.Forms.Button();
            this.ComputeAllBtn = new System.Windows.Forms.Button();
            this.EuclidDialogCancelBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterALabel
            // 
            this.EnterALabel.AutoSize = true;
            this.EnterALabel.Location = new System.Drawing.Point(21, 21);
            this.EnterALabel.Name = "EnterALabel";
            this.EnterALabel.Size = new System.Drawing.Size(44, 13);
            this.EnterALabel.TabIndex = 0;
            this.EnterALabel.Text = "Enter a:";
            // 
            // EnterBLabel
            // 
            this.EnterBLabel.AutoSize = true;
            this.EnterBLabel.Location = new System.Drawing.Point(22, 51);
            this.EnterBLabel.Name = "EnterBLabel";
            this.EnterBLabel.Size = new System.Drawing.Size(44, 13);
            this.EnterBLabel.TabIndex = 1;
            this.EnterBLabel.Text = "Enter b:";
            // 
            // EntryATbox
            // 
            this.EntryATbox.Location = new System.Drawing.Point(80, 18);
            this.EntryATbox.Name = "EntryATbox";
            this.EntryATbox.Size = new System.Drawing.Size(100, 20);
            this.EntryATbox.TabIndex = 2;
            // 
            // EntryBTbox
            // 
            this.EntryBTbox.Location = new System.Drawing.Point(80, 48);
            this.EntryBTbox.Name = "EntryBTbox";
            this.EntryBTbox.Size = new System.Drawing.Size(100, 20);
            this.EntryBTbox.TabIndex = 3;
            // 
            // AddNumsBtn
            // 
            this.AddNumsBtn.Location = new System.Drawing.Point(201, 45);
            this.AddNumsBtn.Name = "AddNumsBtn";
            this.AddNumsBtn.Size = new System.Drawing.Size(55, 23);
            this.AddNumsBtn.TabIndex = 4;
            this.AddNumsBtn.Text = "Add";
            this.AddNumsBtn.UseVisualStyleBackColor = true;
            // 
            // ComputeAllBtn
            // 
            this.ComputeAllBtn.Location = new System.Drawing.Point(24, 178);
            this.ComputeAllBtn.Name = "ComputeAllBtn";
            this.ComputeAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ComputeAllBtn.TabIndex = 5;
            this.ComputeAllBtn.Text = "Compute";
            this.ComputeAllBtn.UseVisualStyleBackColor = true;
            // 
            // EuclidDialogCancelBtn
            // 
            this.EuclidDialogCancelBtn.Location = new System.Drawing.Point(201, 178);
            this.EuclidDialogCancelBtn.Name = "EuclidDialogCancelBtn";
            this.EuclidDialogCancelBtn.Size = new System.Drawing.Size(55, 23);
            this.EuclidDialogCancelBtn.TabIndex = 6;
            this.EuclidDialogCancelBtn.Text = "Cancel";
            this.EuclidDialogCancelBtn.UseVisualStyleBackColor = true;
            this.EuclidDialogCancelBtn.Click += new System.EventHandler(this.EuclidDialogCancelBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(226, 74);
            this.textBox1.TabIndex = 7;
            // 
            // EuclideanAlgDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 213);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EuclidDialogCancelBtn);
            this.Controls.Add(this.ComputeAllBtn);
            this.Controls.Add(this.AddNumsBtn);
            this.Controls.Add(this.EntryBTbox);
            this.Controls.Add(this.EntryATbox);
            this.Controls.Add(this.EnterBLabel);
            this.Controls.Add(this.EnterALabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EuclideanAlgDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compute Multiple Divisors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterALabel;
        private System.Windows.Forms.Label EnterBLabel;
        private System.Windows.Forms.TextBox EntryATbox;
        private System.Windows.Forms.TextBox EntryBTbox;
        private System.Windows.Forms.Button AddNumsBtn;
        private System.Windows.Forms.Button ComputeAllBtn;
        private System.Windows.Forms.Button EuclidDialogCancelBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}