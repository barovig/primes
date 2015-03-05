namespace Maths_Project
{
    partial class PrimesDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimesDialogForm));
            this.q1InserNumsLabel = new System.Windows.Forms.Label();
            this.q1InsertNumsTbox = new System.Windows.Forms.TextBox();
            this.q1CheckNumsBtn = new System.Windows.Forms.Button();
            this.q1CloseDialogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q1InserNumsLabel
            // 
            this.q1InserNumsLabel.AutoSize = true;
            this.q1InserNumsLabel.Location = new System.Drawing.Point(12, 18);
            this.q1InserNumsLabel.Name = "q1InserNumsLabel";
            this.q1InserNumsLabel.Size = new System.Drawing.Size(175, 13);
            this.q1InserNumsLabel.TabIndex = 0;
            this.q1InserNumsLabel.Text = "Insert numbers separated by space:";
            // 
            // q1InsertNumsTbox
            // 
            this.q1InsertNumsTbox.Location = new System.Drawing.Point(14, 34);
            this.q1InsertNumsTbox.Name = "q1InsertNumsTbox";
            this.q1InsertNumsTbox.Size = new System.Drawing.Size(257, 20);
            this.q1InsertNumsTbox.TabIndex = 1;
            this.q1InsertNumsTbox.Text = "30 31 487 8893 987654323 131317171919";
            this.q1InsertNumsTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q1InsertNumsTbox_KeyDown);
            // 
            // q1CheckNumsBtn
            // 
            this.q1CheckNumsBtn.Location = new System.Drawing.Point(15, 96);
            this.q1CheckNumsBtn.Name = "q1CheckNumsBtn";
            this.q1CheckNumsBtn.Size = new System.Drawing.Size(92, 23);
            this.q1CheckNumsBtn.TabIndex = 2;
            this.q1CheckNumsBtn.Text = "Check Numbers";
            this.q1CheckNumsBtn.UseVisualStyleBackColor = true;
            this.q1CheckNumsBtn.Click += new System.EventHandler(this.q1CheckNumsBtn_Click);
            // 
            // q1CloseDialogBtn
            // 
            this.q1CloseDialogBtn.Location = new System.Drawing.Point(179, 96);
            this.q1CloseDialogBtn.Name = "q1CloseDialogBtn";
            this.q1CloseDialogBtn.Size = new System.Drawing.Size(92, 23);
            this.q1CloseDialogBtn.TabIndex = 3;
            this.q1CloseDialogBtn.Text = "Cancel";
            this.q1CloseDialogBtn.UseVisualStyleBackColor = true;
            this.q1CloseDialogBtn.Click += new System.EventHandler(this.q1CloseDialogBtn_Click);
            // 
            // PrimesDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 145);
            this.ControlBox = false;
            this.Controls.Add(this.q1CloseDialogBtn);
            this.Controls.Add(this.q1CheckNumsBtn);
            this.Controls.Add(this.q1InsertNumsTbox);
            this.Controls.Add(this.q1InserNumsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimesDialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Multiple Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label q1InserNumsLabel;
        private System.Windows.Forms.TextBox q1InsertNumsTbox;
        private System.Windows.Forms.Button q1CheckNumsBtn;
        private System.Windows.Forms.Button q1CloseDialogBtn;
    }
}