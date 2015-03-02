namespace Maths_Project
{
    partial class RSADialogForm
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
            this.EnterPLabel = new System.Windows.Forms.Label();
            this.EnterQLabel = new System.Windows.Forms.Label();
            this.EnterELabel = new System.Windows.Forms.Label();
            this.OutputNLabel = new System.Windows.Forms.Label();
            this.OutputPhiLabel = new System.Windows.Forms.Label();
            this.OutputDLabel = new System.Windows.Forms.Label();
            this.EnterPTbox = new System.Windows.Forms.TextBox();
            this.EnterQTbox = new System.Windows.Forms.TextBox();
            this.EnterETbox = new System.Windows.Forms.TextBox();
            this.OutputNTbox = new System.Windows.Forms.TextBox();
            this.OutputPhiTbox = new System.Windows.Forms.TextBox();
            this.OutputDTbox = new System.Windows.Forms.TextBox();
            this.RSAGenerateBtn = new System.Windows.Forms.Button();
            this.RSACancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterPLabel
            // 
            this.EnterPLabel.AutoSize = true;
            this.EnterPLabel.Location = new System.Drawing.Point(3, 19);
            this.EnterPLabel.Name = "EnterPLabel";
            this.EnterPLabel.Size = new System.Drawing.Size(44, 13);
            this.EnterPLabel.TabIndex = 0;
            this.EnterPLabel.Text = "Enter p:";
            // 
            // EnterQLabel
            // 
            this.EnterQLabel.AutoSize = true;
            this.EnterQLabel.Location = new System.Drawing.Point(3, 45);
            this.EnterQLabel.Name = "EnterQLabel";
            this.EnterQLabel.Size = new System.Drawing.Size(44, 13);
            this.EnterQLabel.TabIndex = 1;
            this.EnterQLabel.Text = "Enter q:";
            // 
            // EnterELabel
            // 
            this.EnterELabel.AutoSize = true;
            this.EnterELabel.Location = new System.Drawing.Point(3, 71);
            this.EnterELabel.Name = "EnterELabel";
            this.EnterELabel.Size = new System.Drawing.Size(122, 13);
            this.EnterELabel.TabIndex = 2;
            this.EnterELabel.Text = "Enter encryption key (e):";
            // 
            // OutputNLabel
            // 
            this.OutputNLabel.AutoSize = true;
            this.OutputNLabel.Location = new System.Drawing.Point(3, 136);
            this.OutputNLabel.Name = "OutputNLabel";
            this.OutputNLabel.Size = new System.Drawing.Size(37, 13);
            this.OutputNLabel.TabIndex = 3;
            this.OutputNLabel.Text = "n(p,q):";
            // 
            // OutputPhiLabel
            // 
            this.OutputPhiLabel.AutoSize = true;
            this.OutputPhiLabel.Location = new System.Drawing.Point(3, 162);
            this.OutputPhiLabel.Name = "OutputPhiLabel";
            this.OutputPhiLabel.Size = new System.Drawing.Size(41, 13);
            this.OutputPhiLabel.TabIndex = 4;
            this.OutputPhiLabel.Text = "Φ(p,q):";
            // 
            // OutputDLabel
            // 
            this.OutputDLabel.AutoSize = true;
            this.OutputDLabel.Location = new System.Drawing.Point(3, 182);
            this.OutputDLabel.Name = "OutputDLabel";
            this.OutputDLabel.Size = new System.Drawing.Size(96, 13);
            this.OutputDLabel.TabIndex = 5;
            this.OutputDLabel.Text = "Decryption key (d):";
            // 
            // EnterPTbox
            // 
            this.EnterPTbox.Location = new System.Drawing.Point(53, 16);
            this.EnterPTbox.Name = "EnterPTbox";
            this.EnterPTbox.Size = new System.Drawing.Size(215, 20);
            this.EnterPTbox.TabIndex = 6;
            // 
            // EnterQTbox
            // 
            this.EnterQTbox.Location = new System.Drawing.Point(53, 42);
            this.EnterQTbox.Name = "EnterQTbox";
            this.EnterQTbox.Size = new System.Drawing.Size(215, 20);
            this.EnterQTbox.TabIndex = 7;
            // 
            // EnterETbox
            // 
            this.EnterETbox.Location = new System.Drawing.Point(131, 68);
            this.EnterETbox.Name = "EnterETbox";
            this.EnterETbox.Size = new System.Drawing.Size(137, 20);
            this.EnterETbox.TabIndex = 8;
            // 
            // OutputNTbox
            // 
            this.OutputNTbox.Location = new System.Drawing.Point(50, 133);
            this.OutputNTbox.Name = "OutputNTbox";
            this.OutputNTbox.ReadOnly = true;
            this.OutputNTbox.Size = new System.Drawing.Size(221, 20);
            this.OutputNTbox.TabIndex = 9;
            // 
            // OutputPhiTbox
            // 
            this.OutputPhiTbox.Location = new System.Drawing.Point(50, 159);
            this.OutputPhiTbox.Name = "OutputPhiTbox";
            this.OutputPhiTbox.ReadOnly = true;
            this.OutputPhiTbox.Size = new System.Drawing.Size(221, 20);
            this.OutputPhiTbox.TabIndex = 10;
            // 
            // OutputDTbox
            // 
            this.OutputDTbox.Location = new System.Drawing.Point(50, 198);
            this.OutputDTbox.Name = "OutputDTbox";
            this.OutputDTbox.ReadOnly = true;
            this.OutputDTbox.Size = new System.Drawing.Size(221, 20);
            this.OutputDTbox.TabIndex = 11;
            // 
            // RSAGenerateBtn
            // 
            this.RSAGenerateBtn.Location = new System.Drawing.Point(50, 233);
            this.RSAGenerateBtn.Name = "RSAGenerateBtn";
            this.RSAGenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.RSAGenerateBtn.TabIndex = 12;
            this.RSAGenerateBtn.Text = "Generate";
            this.RSAGenerateBtn.UseVisualStyleBackColor = true;
            // 
            // RSACancelBtn
            // 
            this.RSACancelBtn.Location = new System.Drawing.Point(173, 233);
            this.RSACancelBtn.Name = "RSACancelBtn";
            this.RSACancelBtn.Size = new System.Drawing.Size(75, 23);
            this.RSACancelBtn.TabIndex = 13;
            this.RSACancelBtn.Text = "Cancel";
            this.RSACancelBtn.UseVisualStyleBackColor = true;
            this.RSACancelBtn.Click += new System.EventHandler(this.RSACancelBtn_Click);
            // 
            // RSADialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 271);
            this.ControlBox = false;
            this.Controls.Add(this.RSACancelBtn);
            this.Controls.Add(this.RSAGenerateBtn);
            this.Controls.Add(this.OutputDTbox);
            this.Controls.Add(this.OutputPhiTbox);
            this.Controls.Add(this.OutputNTbox);
            this.Controls.Add(this.EnterETbox);
            this.Controls.Add(this.EnterQTbox);
            this.Controls.Add(this.EnterPTbox);
            this.Controls.Add(this.OutputDLabel);
            this.Controls.Add(this.OutputPhiLabel);
            this.Controls.Add(this.OutputNLabel);
            this.Controls.Add(this.EnterELabel);
            this.Controls.Add(this.EnterQLabel);
            this.Controls.Add(this.EnterPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RSADialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate RSA keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPLabel;
        private System.Windows.Forms.Label EnterQLabel;
        private System.Windows.Forms.Label EnterELabel;
        private System.Windows.Forms.Label OutputNLabel;
        private System.Windows.Forms.Label OutputPhiLabel;
        private System.Windows.Forms.Label OutputDLabel;
        private System.Windows.Forms.TextBox EnterPTbox;
        private System.Windows.Forms.TextBox EnterQTbox;
        private System.Windows.Forms.TextBox EnterETbox;
        private System.Windows.Forms.TextBox OutputNTbox;
        private System.Windows.Forms.TextBox OutputPhiTbox;
        private System.Windows.Forms.TextBox OutputDTbox;
        private System.Windows.Forms.Button RSAGenerateBtn;
        private System.Windows.Forms.Button RSACancelBtn;
    }
}