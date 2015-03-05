namespace Maths_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuTabControl = new System.Windows.Forms.TabControl();
            this.Q1Tab = new System.Windows.Forms.TabPage();
            this.q1NumEntryTbx = new System.Windows.Forms.TextBox();
            this.q1CheckMultipleBtn = new System.Windows.Forms.Button();
            this.q1CheckPrimeBtn = new System.Windows.Forms.Button();
            this.q1ResponseLabel = new System.Windows.Forms.Label();
            this.q1EntNumLabel = new System.Windows.Forms.Label();
            this.q1Label = new System.Windows.Forms.Label();
            this.Q2Tab = new System.Windows.Forms.TabPage();
            this.q2FactorListLabel = new System.Windows.Forms.Label();
            this.q2ResultRTbx = new System.Windows.Forms.RichTextBox();
            this.q2FactorizeMultpBtn = new System.Windows.Forms.Button();
            this.q2FactorizeBtn = new System.Windows.Forms.Button();
            this.q2NumEntryTbx = new System.Windows.Forms.TextBox();
            this.q2EnterNumLabel = new System.Windows.Forms.Label();
            this.q2Label = new System.Windows.Forms.Label();
            this.Q3Tab = new System.Windows.Forms.TabPage();
            this.q3ComputeMultBtn = new System.Windows.Forms.Button();
            this.q3CalcGcdBtn = new System.Windows.Forms.Button();
            this.q3GcdOutLabel = new System.Windows.Forms.Label();
            this.q3EntryBTbox = new System.Windows.Forms.TextBox();
            this.q3EntryATbox = new System.Windows.Forms.TextBox();
            this.q3EnterBLabel = new System.Windows.Forms.Label();
            this.q3EnterALabel = new System.Windows.Forms.Label();
            this.q3Label = new System.Windows.Forms.Label();
            this.Q4Tab = new System.Windows.Forms.TabPage();
            this.q4YOutTbox = new System.Windows.Forms.TextBox();
            this.q4XOutTbox = new System.Windows.Forms.TextBox();
            this.q4GcdOutTbox = new System.Windows.Forms.TextBox();
            this.q4EqtnOutTbox = new System.Windows.Forms.TextBox();
            this.q4ComputeMultBtn = new System.Windows.Forms.Button();
            this.q4Compute = new System.Windows.Forms.Button();
            this.q4CoeffYLabel = new System.Windows.Forms.Label();
            this.q4CoeffXLabel = new System.Windows.Forms.Label();
            this.q4GcdLabel = new System.Windows.Forms.Label();
            this.q4EqtnStaticLabel = new System.Windows.Forms.Label();
            this.q4EntryBTbox = new System.Windows.Forms.TextBox();
            this.q4EntryATbox = new System.Windows.Forms.TextBox();
            this.q4EnterBLabel = new System.Windows.Forms.Label();
            this.q4EnterALabel = new System.Windows.Forms.Label();
            this.q4Label = new System.Windows.Forms.Label();
            this.Q5Tab = new System.Windows.Forms.TabPage();
            this.q5GenerateKeysBtn = new System.Windows.Forms.Button();
            this.q5EncryptBtn = new System.Windows.Forms.Button();
            this.q5CypherTbox = new System.Windows.Forms.TextBox();
            this.q5CyphertxtLabel = new System.Windows.Forms.Label();
            this.q5RsaModTbox = new System.Windows.Forms.TextBox();
            this.q5EncrExpTbox = new System.Windows.Forms.TextBox();
            this.q5RsaModLabel = new System.Windows.Forms.Label();
            this.q5EncrExpLabel = new System.Windows.Forms.Label();
            this.q5MsgEntryTbox = new System.Windows.Forms.TextBox();
            this.q5MessageLabel = new System.Windows.Forms.Label();
            this.q5Label = new System.Windows.Forms.Label();
            this.Q6Tab = new System.Windows.Forms.TabPage();
            this.q6GenerateKeysBtn = new System.Windows.Forms.Button();
            this.q6DecryptBtn = new System.Windows.Forms.Button();
            this.q6PlainTxtTbox = new System.Windows.Forms.TextBox();
            this.q6PlainTxtLabel = new System.Windows.Forms.Label();
            this.q6RsaModTbox = new System.Windows.Forms.TextBox();
            this.q6DecryptExpTbox = new System.Windows.Forms.TextBox();
            this.q6RsaModLabel = new System.Windows.Forms.Label();
            this.q6DecryptExpLabel = new System.Windows.Forms.Label();
            this.q6CypherTbox = new System.Windows.Forms.TextBox();
            this.q6CypherLabel = new System.Windows.Forms.Label();
            this.q6Label = new System.Windows.Forms.Label();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.HelpGenerateReportBtn = new System.Windows.Forms.Button();
            this.helpTbox = new System.Windows.Forms.RichTextBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.MenuTabControl.SuspendLayout();
            this.Q1Tab.SuspendLayout();
            this.Q2Tab.SuspendLayout();
            this.Q3Tab.SuspendLayout();
            this.Q4Tab.SuspendLayout();
            this.Q5Tab.SuspendLayout();
            this.Q6Tab.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTabControl
            // 
            this.MenuTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MenuTabControl.Controls.Add(this.Q1Tab);
            this.MenuTabControl.Controls.Add(this.Q2Tab);
            this.MenuTabControl.Controls.Add(this.Q3Tab);
            this.MenuTabControl.Controls.Add(this.Q4Tab);
            this.MenuTabControl.Controls.Add(this.Q5Tab);
            this.MenuTabControl.Controls.Add(this.Q6Tab);
            this.MenuTabControl.Controls.Add(this.HelpTab);
            this.MenuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTabControl.ItemSize = new System.Drawing.Size(60, 21);
            this.MenuTabControl.Location = new System.Drawing.Point(0, 0);
            this.MenuTabControl.Name = "MenuTabControl";
            this.MenuTabControl.SelectedIndex = 0;
            this.MenuTabControl.Size = new System.Drawing.Size(491, 278);
            this.MenuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MenuTabControl.TabIndex = 0;
            // 
            // Q1Tab
            // 
            this.Q1Tab.Controls.Add(this.q1NumEntryTbx);
            this.Q1Tab.Controls.Add(this.q1CheckMultipleBtn);
            this.Q1Tab.Controls.Add(this.q1CheckPrimeBtn);
            this.Q1Tab.Controls.Add(this.q1ResponseLabel);
            this.Q1Tab.Controls.Add(this.q1EntNumLabel);
            this.Q1Tab.Controls.Add(this.q1Label);
            this.Q1Tab.Location = new System.Drawing.Point(4, 25);
            this.Q1Tab.Name = "Q1Tab";
            this.Q1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Q1Tab.Size = new System.Drawing.Size(483, 249);
            this.Q1Tab.TabIndex = 0;
            this.Q1Tab.Text = "Q I";
            this.Q1Tab.UseVisualStyleBackColor = true;
            // 
            // q1NumEntryTbx
            // 
            this.q1NumEntryTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q1NumEntryTbx.Location = new System.Drawing.Point(144, 51);
            this.q1NumEntryTbx.Name = "q1NumEntryTbx";
            this.q1NumEntryTbx.Size = new System.Drawing.Size(287, 23);
            this.q1NumEntryTbx.TabIndex = 5;
            this.q1NumEntryTbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q1NumEntryTbx_KeyDown);
            // 
            // q1CheckMultipleBtn
            // 
            this.q1CheckMultipleBtn.Location = new System.Drawing.Point(351, 206);
            this.q1CheckMultipleBtn.Name = "q1CheckMultipleBtn";
            this.q1CheckMultipleBtn.Size = new System.Drawing.Size(103, 23);
            this.q1CheckMultipleBtn.TabIndex = 4;
            this.q1CheckMultipleBtn.Text = "Check Multiple..";
            this.q1CheckMultipleBtn.UseVisualStyleBackColor = true;
            this.q1CheckMultipleBtn.Click += new System.EventHandler(this.q1CheckMultipleBtn_Click);
            // 
            // q1CheckPrimeBtn
            // 
            this.q1CheckPrimeBtn.Location = new System.Drawing.Point(42, 206);
            this.q1CheckPrimeBtn.Name = "q1CheckPrimeBtn";
            this.q1CheckPrimeBtn.Size = new System.Drawing.Size(75, 23);
            this.q1CheckPrimeBtn.TabIndex = 3;
            this.q1CheckPrimeBtn.Text = "Check";
            this.q1CheckPrimeBtn.UseVisualStyleBackColor = true;
            this.q1CheckPrimeBtn.Click += new System.EventHandler(this.q1CheckPrimeBtn_Click);
            // 
            // q1ResponseLabel
            // 
            this.q1ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q1ResponseLabel.Location = new System.Drawing.Point(0, 115);
            this.q1ResponseLabel.Name = "q1ResponseLabel";
            this.q1ResponseLabel.Size = new System.Drawing.Size(483, 17);
            this.q1ResponseLabel.TabIndex = 2;
            this.q1ResponseLabel.Text = "Enter the number above";
            this.q1ResponseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q1EntNumLabel
            // 
            this.q1EntNumLabel.AutoSize = true;
            this.q1EntNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q1EntNumLabel.Location = new System.Drawing.Point(40, 54);
            this.q1EntNumLabel.Name = "q1EntNumLabel";
            this.q1EntNumLabel.Size = new System.Drawing.Size(98, 17);
            this.q1EntNumLabel.TabIndex = 1;
            this.q1EntNumLabel.Text = "Enter number:";
            // 
            // q1Label
            // 
            this.q1Label.AutoSize = true;
            this.q1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q1Label.Location = new System.Drawing.Point(170, 3);
            this.q1Label.Name = "q1Label";
            this.q1Label.Size = new System.Drawing.Size(138, 26);
            this.q1Label.TabIndex = 0;
            this.q1Label.Text = "Prime Check";
            this.q1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q2Tab
            // 
            this.Q2Tab.Controls.Add(this.q2FactorListLabel);
            this.Q2Tab.Controls.Add(this.q2ResultRTbx);
            this.Q2Tab.Controls.Add(this.q2FactorizeMultpBtn);
            this.Q2Tab.Controls.Add(this.q2FactorizeBtn);
            this.Q2Tab.Controls.Add(this.q2NumEntryTbx);
            this.Q2Tab.Controls.Add(this.q2EnterNumLabel);
            this.Q2Tab.Controls.Add(this.q2Label);
            this.Q2Tab.Location = new System.Drawing.Point(4, 25);
            this.Q2Tab.Name = "Q2Tab";
            this.Q2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Q2Tab.Size = new System.Drawing.Size(483, 249);
            this.Q2Tab.TabIndex = 1;
            this.Q2Tab.Text = "Q II";
            this.Q2Tab.UseVisualStyleBackColor = true;
            // 
            // q2FactorListLabel
            // 
            this.q2FactorListLabel.AutoSize = true;
            this.q2FactorListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q2FactorListLabel.Location = new System.Drawing.Point(40, 98);
            this.q2FactorListLabel.Name = "q2FactorListLabel";
            this.q2FactorListLabel.Size = new System.Drawing.Size(78, 17);
            this.q2FactorListLabel.TabIndex = 10;
            this.q2FactorListLabel.Text = "Factor List:";
            // 
            // q2ResultRTbx
            // 
            this.q2ResultRTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.q2ResultRTbx.Location = new System.Drawing.Point(43, 118);
            this.q2ResultRTbx.Name = "q2ResultRTbx";
            this.q2ResultRTbx.ReadOnly = true;
            this.q2ResultRTbx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.q2ResultRTbx.Size = new System.Drawing.Size(384, 67);
            this.q2ResultRTbx.TabIndex = 9;
            this.q2ResultRTbx.Text = "";
            // 
            // q2FactorizeMultpBtn
            // 
            this.q2FactorizeMultpBtn.Location = new System.Drawing.Point(351, 206);
            this.q2FactorizeMultpBtn.Name = "q2FactorizeMultpBtn";
            this.q2FactorizeMultpBtn.Size = new System.Drawing.Size(103, 23);
            this.q2FactorizeMultpBtn.TabIndex = 8;
            this.q2FactorizeMultpBtn.Text = "Factorize Multiple..";
            this.q2FactorizeMultpBtn.UseVisualStyleBackColor = true;
            this.q2FactorizeMultpBtn.Click += new System.EventHandler(this.q2FactorizeMultpBtn_Click);
            // 
            // q2FactorizeBtn
            // 
            this.q2FactorizeBtn.Location = new System.Drawing.Point(42, 206);
            this.q2FactorizeBtn.Name = "q2FactorizeBtn";
            this.q2FactorizeBtn.Size = new System.Drawing.Size(75, 23);
            this.q2FactorizeBtn.TabIndex = 7;
            this.q2FactorizeBtn.Text = "Factorize";
            this.q2FactorizeBtn.UseVisualStyleBackColor = true;
            this.q2FactorizeBtn.Click += new System.EventHandler(this.q2FactorizeBtn_Click);
            // 
            // q2NumEntryTbx
            // 
            this.q2NumEntryTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q2NumEntryTbx.Location = new System.Drawing.Point(144, 51);
            this.q2NumEntryTbx.Name = "q2NumEntryTbx";
            this.q2NumEntryTbx.Size = new System.Drawing.Size(287, 23);
            this.q2NumEntryTbx.TabIndex = 6;
            this.q2NumEntryTbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q2NumEntryTbx_KeyDown);
            // 
            // q2EnterNumLabel
            // 
            this.q2EnterNumLabel.AutoSize = true;
            this.q2EnterNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q2EnterNumLabel.Location = new System.Drawing.Point(40, 54);
            this.q2EnterNumLabel.Name = "q2EnterNumLabel";
            this.q2EnterNumLabel.Size = new System.Drawing.Size(98, 17);
            this.q2EnterNumLabel.TabIndex = 2;
            this.q2EnterNumLabel.Text = "Enter number:";
            // 
            // q2Label
            // 
            this.q2Label.AutoSize = true;
            this.q2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q2Label.Location = new System.Drawing.Point(139, 3);
            this.q2Label.Name = "q2Label";
            this.q2Label.Size = new System.Drawing.Size(200, 26);
            this.q2Label.TabIndex = 1;
            this.q2Label.Text = "Prime Factorization";
            this.q2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q3Tab
            // 
            this.Q3Tab.Controls.Add(this.q3ComputeMultBtn);
            this.Q3Tab.Controls.Add(this.q3CalcGcdBtn);
            this.Q3Tab.Controls.Add(this.q3GcdOutLabel);
            this.Q3Tab.Controls.Add(this.q3EntryBTbox);
            this.Q3Tab.Controls.Add(this.q3EntryATbox);
            this.Q3Tab.Controls.Add(this.q3EnterBLabel);
            this.Q3Tab.Controls.Add(this.q3EnterALabel);
            this.Q3Tab.Controls.Add(this.q3Label);
            this.Q3Tab.Location = new System.Drawing.Point(4, 25);
            this.Q3Tab.Name = "Q3Tab";
            this.Q3Tab.Size = new System.Drawing.Size(483, 249);
            this.Q3Tab.TabIndex = 2;
            this.Q3Tab.Text = "Q III";
            this.Q3Tab.UseVisualStyleBackColor = true;
            // 
            // q3ComputeMultBtn
            // 
            this.q3ComputeMultBtn.Location = new System.Drawing.Point(351, 206);
            this.q3ComputeMultBtn.Name = "q3ComputeMultBtn";
            this.q3ComputeMultBtn.Size = new System.Drawing.Size(103, 23);
            this.q3ComputeMultBtn.TabIndex = 14;
            this.q3ComputeMultBtn.Text = "Compute Multiple..";
            this.q3ComputeMultBtn.UseVisualStyleBackColor = true;
            this.q3ComputeMultBtn.Click += new System.EventHandler(this.q3ComputeMultBtn_Click);
            // 
            // q3CalcGcdBtn
            // 
            this.q3CalcGcdBtn.Location = new System.Drawing.Point(42, 206);
            this.q3CalcGcdBtn.Name = "q3CalcGcdBtn";
            this.q3CalcGcdBtn.Size = new System.Drawing.Size(88, 23);
            this.q3CalcGcdBtn.TabIndex = 13;
            this.q3CalcGcdBtn.Text = "Compute GCD";
            this.q3CalcGcdBtn.UseVisualStyleBackColor = true;
            this.q3CalcGcdBtn.Click += new System.EventHandler(this.q3CalcGcdBtn_Click);
            // 
            // q3GcdOutLabel
            // 
            this.q3GcdOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.q3GcdOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3GcdOutLabel.Location = new System.Drawing.Point(0, 106);
            this.q3GcdOutLabel.Name = "q3GcdOutLabel";
            this.q3GcdOutLabel.Size = new System.Drawing.Size(483, 23);
            this.q3GcdOutLabel.TabIndex = 7;
            this.q3GcdOutLabel.Text = "Enter numbers a and b to find Gretest Common Divisor";
            this.q3GcdOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q3EntryBTbox
            // 
            this.q3EntryBTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3EntryBTbox.Location = new System.Drawing.Point(338, 41);
            this.q3EntryBTbox.Name = "q3EntryBTbox";
            this.q3EntryBTbox.Size = new System.Drawing.Size(112, 23);
            this.q3EntryBTbox.TabIndex = 4;
            this.q3EntryBTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q3EntryBTbox_KeyDown);
            // 
            // q3EntryATbox
            // 
            this.q3EntryATbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3EntryATbox.Location = new System.Drawing.Point(112, 41);
            this.q3EntryATbox.Name = "q3EntryATbox";
            this.q3EntryATbox.Size = new System.Drawing.Size(100, 23);
            this.q3EntryATbox.TabIndex = 3;
            this.q3EntryATbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q3EntryATbox_KeyDown);
            // 
            // q3EnterBLabel
            // 
            this.q3EnterBLabel.AutoSize = true;
            this.q3EnterBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3EnterBLabel.Location = new System.Drawing.Point(274, 44);
            this.q3EnterBLabel.Name = "q3EnterBLabel";
            this.q3EnterBLabel.Size = new System.Drawing.Size(58, 17);
            this.q3EnterBLabel.TabIndex = 2;
            this.q3EnterBLabel.Text = "Enter b:";
            // 
            // q3EnterALabel
            // 
            this.q3EnterALabel.AutoSize = true;
            this.q3EnterALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3EnterALabel.Location = new System.Drawing.Point(23, 44);
            this.q3EnterALabel.Name = "q3EnterALabel";
            this.q3EnterALabel.Size = new System.Drawing.Size(58, 17);
            this.q3EnterALabel.TabIndex = 1;
            this.q3EnterALabel.Text = "Enter a:";
            // 
            // q3Label
            // 
            this.q3Label.AutoSize = true;
            this.q3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q3Label.Location = new System.Drawing.Point(136, 3);
            this.q3Label.Name = "q3Label";
            this.q3Label.Size = new System.Drawing.Size(207, 26);
            this.q3Label.TabIndex = 0;
            this.q3Label.Text = "Euclidean Algorithm";
            this.q3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Q4Tab
            // 
            this.Q4Tab.Controls.Add(this.q4YOutTbox);
            this.Q4Tab.Controls.Add(this.q4XOutTbox);
            this.Q4Tab.Controls.Add(this.q4GcdOutTbox);
            this.Q4Tab.Controls.Add(this.q4EqtnOutTbox);
            this.Q4Tab.Controls.Add(this.q4ComputeMultBtn);
            this.Q4Tab.Controls.Add(this.q4Compute);
            this.Q4Tab.Controls.Add(this.q4CoeffYLabel);
            this.Q4Tab.Controls.Add(this.q4CoeffXLabel);
            this.Q4Tab.Controls.Add(this.q4GcdLabel);
            this.Q4Tab.Controls.Add(this.q4EqtnStaticLabel);
            this.Q4Tab.Controls.Add(this.q4EntryBTbox);
            this.Q4Tab.Controls.Add(this.q4EntryATbox);
            this.Q4Tab.Controls.Add(this.q4EnterBLabel);
            this.Q4Tab.Controls.Add(this.q4EnterALabel);
            this.Q4Tab.Controls.Add(this.q4Label);
            this.Q4Tab.Location = new System.Drawing.Point(4, 25);
            this.Q4Tab.Name = "Q4Tab";
            this.Q4Tab.Size = new System.Drawing.Size(483, 249);
            this.Q4Tab.TabIndex = 3;
            this.Q4Tab.Text = "Q IV";
            this.Q4Tab.UseVisualStyleBackColor = true;
            // 
            // q4YOutTbox
            // 
            this.q4YOutTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4YOutTbox.Location = new System.Drawing.Point(338, 144);
            this.q4YOutTbox.Name = "q4YOutTbox";
            this.q4YOutTbox.ReadOnly = true;
            this.q4YOutTbox.Size = new System.Drawing.Size(116, 23);
            this.q4YOutTbox.TabIndex = 19;
            // 
            // q4XOutTbox
            // 
            this.q4XOutTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4XOutTbox.Location = new System.Drawing.Point(338, 115);
            this.q4XOutTbox.Name = "q4XOutTbox";
            this.q4XOutTbox.ReadOnly = true;
            this.q4XOutTbox.Size = new System.Drawing.Size(116, 23);
            this.q4XOutTbox.TabIndex = 18;
            // 
            // q4GcdOutTbox
            // 
            this.q4GcdOutTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4GcdOutTbox.Location = new System.Drawing.Point(338, 86);
            this.q4GcdOutTbox.Name = "q4GcdOutTbox";
            this.q4GcdOutTbox.ReadOnly = true;
            this.q4GcdOutTbox.Size = new System.Drawing.Size(116, 23);
            this.q4GcdOutTbox.TabIndex = 17;
            // 
            // q4EqtnOutTbox
            // 
            this.q4EqtnOutTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EqtnOutTbox.Location = new System.Drawing.Point(26, 115);
            this.q4EqtnOutTbox.Name = "q4EqtnOutTbox";
            this.q4EqtnOutTbox.ReadOnly = true;
            this.q4EqtnOutTbox.Size = new System.Drawing.Size(233, 23);
            this.q4EqtnOutTbox.TabIndex = 16;
            this.q4EqtnOutTbox.Text = "d = x * a + y * b";
            // 
            // q4ComputeMultBtn
            // 
            this.q4ComputeMultBtn.Location = new System.Drawing.Point(351, 206);
            this.q4ComputeMultBtn.Name = "q4ComputeMultBtn";
            this.q4ComputeMultBtn.Size = new System.Drawing.Size(103, 23);
            this.q4ComputeMultBtn.TabIndex = 15;
            this.q4ComputeMultBtn.Text = "Compute Multiple..";
            this.q4ComputeMultBtn.UseVisualStyleBackColor = true;
            this.q4ComputeMultBtn.Click += new System.EventHandler(this.q4ComputeMultBtn_Click);
            // 
            // q4Compute
            // 
            this.q4Compute.Location = new System.Drawing.Point(42, 206);
            this.q4Compute.Name = "q4Compute";
            this.q4Compute.Size = new System.Drawing.Size(88, 23);
            this.q4Compute.TabIndex = 14;
            this.q4Compute.Text = "Compute";
            this.q4Compute.UseVisualStyleBackColor = true;
            this.q4Compute.Click += new System.EventHandler(this.q4Compute_Click);
            // 
            // q4CoeffYLabel
            // 
            this.q4CoeffYLabel.AutoSize = true;
            this.q4CoeffYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4CoeffYLabel.Location = new System.Drawing.Point(314, 147);
            this.q4CoeffYLabel.Name = "q4CoeffYLabel";
            this.q4CoeffYLabel.Size = new System.Drawing.Size(23, 17);
            this.q4CoeffYLabel.TabIndex = 10;
            this.q4CoeffYLabel.Text = "y :";
            // 
            // q4CoeffXLabel
            // 
            this.q4CoeffXLabel.AutoSize = true;
            this.q4CoeffXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4CoeffXLabel.Location = new System.Drawing.Point(314, 118);
            this.q4CoeffXLabel.Name = "q4CoeffXLabel";
            this.q4CoeffXLabel.Size = new System.Drawing.Size(22, 17);
            this.q4CoeffXLabel.TabIndex = 9;
            this.q4CoeffXLabel.Text = "x :";
            // 
            // q4GcdLabel
            // 
            this.q4GcdLabel.AutoSize = true;
            this.q4GcdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4GcdLabel.Location = new System.Drawing.Point(260, 89);
            this.q4GcdLabel.Name = "q4GcdLabel";
            this.q4GcdLabel.Size = new System.Drawing.Size(76, 17);
            this.q4GcdLabel.TabIndex = 8;
            this.q4GcdLabel.Text = "GCD(a,b) :";
            // 
            // q4EqtnStaticLabel
            // 
            this.q4EqtnStaticLabel.AutoSize = true;
            this.q4EqtnStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EqtnStaticLabel.Location = new System.Drawing.Point(23, 92);
            this.q4EqtnStaticLabel.Name = "q4EqtnStaticLabel";
            this.q4EqtnStaticLabel.Size = new System.Drawing.Size(68, 17);
            this.q4EqtnStaticLabel.TabIndex = 6;
            this.q4EqtnStaticLabel.Text = "Equation:";
            // 
            // q4EntryBTbox
            // 
            this.q4EntryBTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EntryBTbox.Location = new System.Drawing.Point(338, 41);
            this.q4EntryBTbox.Name = "q4EntryBTbox";
            this.q4EntryBTbox.Size = new System.Drawing.Size(112, 23);
            this.q4EntryBTbox.TabIndex = 5;
            this.q4EntryBTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q4EntryBTbox_KeyDown);
            // 
            // q4EntryATbox
            // 
            this.q4EntryATbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EntryATbox.Location = new System.Drawing.Point(112, 41);
            this.q4EntryATbox.Name = "q4EntryATbox";
            this.q4EntryATbox.Size = new System.Drawing.Size(100, 23);
            this.q4EntryATbox.TabIndex = 4;
            this.q4EntryATbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q4EntryATbox_KeyDown);
            // 
            // q4EnterBLabel
            // 
            this.q4EnterBLabel.AutoSize = true;
            this.q4EnterBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EnterBLabel.Location = new System.Drawing.Point(274, 44);
            this.q4EnterBLabel.Name = "q4EnterBLabel";
            this.q4EnterBLabel.Size = new System.Drawing.Size(58, 17);
            this.q4EnterBLabel.TabIndex = 3;
            this.q4EnterBLabel.Text = "Enter b:";
            // 
            // q4EnterALabel
            // 
            this.q4EnterALabel.AutoSize = true;
            this.q4EnterALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4EnterALabel.Location = new System.Drawing.Point(23, 44);
            this.q4EnterALabel.Name = "q4EnterALabel";
            this.q4EnterALabel.Size = new System.Drawing.Size(58, 17);
            this.q4EnterALabel.TabIndex = 2;
            this.q4EnterALabel.Text = "Enter a:";
            // 
            // q4Label
            // 
            this.q4Label.AutoSize = true;
            this.q4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q4Label.Location = new System.Drawing.Point(88, 3);
            this.q4Label.Name = "q4Label";
            this.q4Label.Size = new System.Drawing.Size(305, 26);
            this.q4Label.TabIndex = 0;
            this.q4Label.Text = "Extended Euclidean Algorithm";
            // 
            // Q5Tab
            // 
            this.Q5Tab.Controls.Add(this.q5GenerateKeysBtn);
            this.Q5Tab.Controls.Add(this.q5EncryptBtn);
            this.Q5Tab.Controls.Add(this.q5CypherTbox);
            this.Q5Tab.Controls.Add(this.q5CyphertxtLabel);
            this.Q5Tab.Controls.Add(this.q5RsaModTbox);
            this.Q5Tab.Controls.Add(this.q5EncrExpTbox);
            this.Q5Tab.Controls.Add(this.q5RsaModLabel);
            this.Q5Tab.Controls.Add(this.q5EncrExpLabel);
            this.Q5Tab.Controls.Add(this.q5MsgEntryTbox);
            this.Q5Tab.Controls.Add(this.q5MessageLabel);
            this.Q5Tab.Controls.Add(this.q5Label);
            this.Q5Tab.Location = new System.Drawing.Point(4, 25);
            this.Q5Tab.Name = "Q5Tab";
            this.Q5Tab.Size = new System.Drawing.Size(483, 249);
            this.Q5Tab.TabIndex = 4;
            this.Q5Tab.Text = "Q V";
            this.Q5Tab.UseVisualStyleBackColor = true;
            // 
            // q5GenerateKeysBtn
            // 
            this.q5GenerateKeysBtn.Location = new System.Drawing.Point(351, 206);
            this.q5GenerateKeysBtn.Name = "q5GenerateKeysBtn";
            this.q5GenerateKeysBtn.Size = new System.Drawing.Size(103, 23);
            this.q5GenerateKeysBtn.TabIndex = 16;
            this.q5GenerateKeysBtn.Text = "Generate Keys";
            this.q5GenerateKeysBtn.UseVisualStyleBackColor = true;
            this.q5GenerateKeysBtn.Click += new System.EventHandler(this.q5GenerateKeysBtn_Click);
            // 
            // q5EncryptBtn
            // 
            this.q5EncryptBtn.Location = new System.Drawing.Point(42, 206);
            this.q5EncryptBtn.Name = "q5EncryptBtn";
            this.q5EncryptBtn.Size = new System.Drawing.Size(88, 23);
            this.q5EncryptBtn.TabIndex = 15;
            this.q5EncryptBtn.Text = "Encrypt";
            this.q5EncryptBtn.UseVisualStyleBackColor = true;
            this.q5EncryptBtn.Click += new System.EventHandler(this.q5EncryptBtn_Click);
            // 
            // q5CypherTbox
            // 
            this.q5CypherTbox.Location = new System.Drawing.Point(42, 171);
            this.q5CypherTbox.Name = "q5CypherTbox";
            this.q5CypherTbox.ReadOnly = true;
            this.q5CypherTbox.Size = new System.Drawing.Size(412, 20);
            this.q5CypherTbox.TabIndex = 8;
            // 
            // q5CyphertxtLabel
            // 
            this.q5CyphertxtLabel.AutoSize = true;
            this.q5CyphertxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q5CyphertxtLabel.Location = new System.Drawing.Point(39, 151);
            this.q5CyphertxtLabel.Name = "q5CyphertxtLabel";
            this.q5CyphertxtLabel.Size = new System.Drawing.Size(79, 17);
            this.q5CyphertxtLabel.TabIndex = 7;
            this.q5CyphertxtLabel.Text = "Cyphertext:";
            // 
            // q5RsaModTbox
            // 
            this.q5RsaModTbox.Location = new System.Drawing.Point(225, 114);
            this.q5RsaModTbox.Name = "q5RsaModTbox";
            this.q5RsaModTbox.Size = new System.Drawing.Size(184, 20);
            this.q5RsaModTbox.TabIndex = 6;
            this.q5RsaModTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q5RsaModTbox_KeyDown);
            // 
            // q5EncrExpTbox
            // 
            this.q5EncrExpTbox.Location = new System.Drawing.Point(225, 88);
            this.q5EncrExpTbox.Name = "q5EncrExpTbox";
            this.q5EncrExpTbox.Size = new System.Drawing.Size(184, 20);
            this.q5EncrExpTbox.TabIndex = 5;
            this.q5EncrExpTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q5EncrExpTbox_KeyDown);
            // 
            // q5RsaModLabel
            // 
            this.q5RsaModLabel.AutoSize = true;
            this.q5RsaModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q5RsaModLabel.Location = new System.Drawing.Point(80, 116);
            this.q5RsaModLabel.Name = "q5RsaModLabel";
            this.q5RsaModLabel.Size = new System.Drawing.Size(139, 17);
            this.q5RsaModLabel.TabIndex = 4;
            this.q5RsaModLabel.Text = "Enter RSA Modulus: ";
            // 
            // q5EncrExpLabel
            // 
            this.q5EncrExpLabel.AutoSize = true;
            this.q5EncrExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q5EncrExpLabel.Location = new System.Drawing.Point(39, 88);
            this.q5EncrExpLabel.Name = "q5EncrExpLabel";
            this.q5EncrExpLabel.Size = new System.Drawing.Size(180, 17);
            this.q5EncrExpLabel.TabIndex = 3;
            this.q5EncrExpLabel.Text = "Enter Encryption Exponent:";
            // 
            // q5MsgEntryTbox
            // 
            this.q5MsgEntryTbox.Location = new System.Drawing.Point(42, 56);
            this.q5MsgEntryTbox.Name = "q5MsgEntryTbox";
            this.q5MsgEntryTbox.Size = new System.Drawing.Size(412, 20);
            this.q5MsgEntryTbox.TabIndex = 2;
            this.q5MsgEntryTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q5MsgEntryTbox_KeyDown);
            // 
            // q5MessageLabel
            // 
            this.q5MessageLabel.AutoSize = true;
            this.q5MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q5MessageLabel.Location = new System.Drawing.Point(39, 36);
            this.q5MessageLabel.Name = "q5MessageLabel";
            this.q5MessageLabel.Size = new System.Drawing.Size(107, 17);
            this.q5MessageLabel.TabIndex = 1;
            this.q5MessageLabel.Text = "Enter message:";
            // 
            // q5Label
            // 
            this.q5Label.AutoSize = true;
            this.q5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q5Label.Location = new System.Drawing.Point(156, 3);
            this.q5Label.Name = "q5Label";
            this.q5Label.Size = new System.Drawing.Size(167, 26);
            this.q5Label.TabIndex = 0;
            this.q5Label.Text = "RSA Encryption";
            // 
            // Q6Tab
            // 
            this.Q6Tab.Controls.Add(this.q6GenerateKeysBtn);
            this.Q6Tab.Controls.Add(this.q6DecryptBtn);
            this.Q6Tab.Controls.Add(this.q6PlainTxtTbox);
            this.Q6Tab.Controls.Add(this.q6PlainTxtLabel);
            this.Q6Tab.Controls.Add(this.q6RsaModTbox);
            this.Q6Tab.Controls.Add(this.q6DecryptExpTbox);
            this.Q6Tab.Controls.Add(this.q6RsaModLabel);
            this.Q6Tab.Controls.Add(this.q6DecryptExpLabel);
            this.Q6Tab.Controls.Add(this.q6CypherTbox);
            this.Q6Tab.Controls.Add(this.q6CypherLabel);
            this.Q6Tab.Controls.Add(this.q6Label);
            this.Q6Tab.Location = new System.Drawing.Point(4, 25);
            this.Q6Tab.Name = "Q6Tab";
            this.Q6Tab.Size = new System.Drawing.Size(483, 249);
            this.Q6Tab.TabIndex = 5;
            this.Q6Tab.Text = "Q VI";
            this.Q6Tab.UseVisualStyleBackColor = true;
            // 
            // q6GenerateKeysBtn
            // 
            this.q6GenerateKeysBtn.Location = new System.Drawing.Point(351, 206);
            this.q6GenerateKeysBtn.Name = "q6GenerateKeysBtn";
            this.q6GenerateKeysBtn.Size = new System.Drawing.Size(103, 23);
            this.q6GenerateKeysBtn.TabIndex = 17;
            this.q6GenerateKeysBtn.Text = "Generate Keys";
            this.q6GenerateKeysBtn.UseVisualStyleBackColor = true;
            this.q6GenerateKeysBtn.Click += new System.EventHandler(this.q6GenerateKeysBtn_Click);
            // 
            // q6DecryptBtn
            // 
            this.q6DecryptBtn.Location = new System.Drawing.Point(42, 206);
            this.q6DecryptBtn.Name = "q6DecryptBtn";
            this.q6DecryptBtn.Size = new System.Drawing.Size(88, 23);
            this.q6DecryptBtn.TabIndex = 16;
            this.q6DecryptBtn.Text = "Decrypt";
            this.q6DecryptBtn.UseVisualStyleBackColor = true;
            this.q6DecryptBtn.Click += new System.EventHandler(this.q6DecryptBtn_Click);
            // 
            // q6PlainTxtTbox
            // 
            this.q6PlainTxtTbox.Location = new System.Drawing.Point(42, 171);
            this.q6PlainTxtTbox.Name = "q6PlainTxtTbox";
            this.q6PlainTxtTbox.ReadOnly = true;
            this.q6PlainTxtTbox.Size = new System.Drawing.Size(412, 20);
            this.q6PlainTxtTbox.TabIndex = 9;
            // 
            // q6PlainTxtLabel
            // 
            this.q6PlainTxtLabel.AutoSize = true;
            this.q6PlainTxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q6PlainTxtLabel.Location = new System.Drawing.Point(39, 151);
            this.q6PlainTxtLabel.Name = "q6PlainTxtLabel";
            this.q6PlainTxtLabel.Size = new System.Drawing.Size(126, 17);
            this.q6PlainTxtLabel.TabIndex = 8;
            this.q6PlainTxtLabel.Text = "Plaintext Message:";
            // 
            // q6RsaModTbox
            // 
            this.q6RsaModTbox.Location = new System.Drawing.Point(225, 114);
            this.q6RsaModTbox.Name = "q6RsaModTbox";
            this.q6RsaModTbox.Size = new System.Drawing.Size(184, 20);
            this.q6RsaModTbox.TabIndex = 7;
            this.q6RsaModTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q6RsaModTbox_KeyDown);
            // 
            // q6DecryptExpTbox
            // 
            this.q6DecryptExpTbox.Location = new System.Drawing.Point(225, 88);
            this.q6DecryptExpTbox.Name = "q6DecryptExpTbox";
            this.q6DecryptExpTbox.Size = new System.Drawing.Size(184, 20);
            this.q6DecryptExpTbox.TabIndex = 6;
            this.q6DecryptExpTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q6DecryptExpTbox_KeyDown);
            // 
            // q6RsaModLabel
            // 
            this.q6RsaModLabel.AutoSize = true;
            this.q6RsaModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q6RsaModLabel.Location = new System.Drawing.Point(80, 116);
            this.q6RsaModLabel.Name = "q6RsaModLabel";
            this.q6RsaModLabel.Size = new System.Drawing.Size(139, 17);
            this.q6RsaModLabel.TabIndex = 5;
            this.q6RsaModLabel.Text = "Enter RSA Modulus: ";
            // 
            // q6DecryptExpLabel
            // 
            this.q6DecryptExpLabel.AutoSize = true;
            this.q6DecryptExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q6DecryptExpLabel.Location = new System.Drawing.Point(39, 88);
            this.q6DecryptExpLabel.Name = "q6DecryptExpLabel";
            this.q6DecryptExpLabel.Size = new System.Drawing.Size(181, 17);
            this.q6DecryptExpLabel.TabIndex = 4;
            this.q6DecryptExpLabel.Text = "Enter Decryption Exponent:";
            // 
            // q6CypherTbox
            // 
            this.q6CypherTbox.Location = new System.Drawing.Point(42, 56);
            this.q6CypherTbox.Name = "q6CypherTbox";
            this.q6CypherTbox.Size = new System.Drawing.Size(412, 20);
            this.q6CypherTbox.TabIndex = 3;
            this.q6CypherTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.q6CypherTbox_KeyDown);
            // 
            // q6CypherLabel
            // 
            this.q6CypherLabel.AutoSize = true;
            this.q6CypherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q6CypherLabel.Location = new System.Drawing.Point(39, 36);
            this.q6CypherLabel.Name = "q6CypherLabel";
            this.q6CypherLabel.Size = new System.Drawing.Size(115, 17);
            this.q6CypherLabel.TabIndex = 2;
            this.q6CypherLabel.Text = "Enter cyphertext:";
            // 
            // q6Label
            // 
            this.q6Label.AutoSize = true;
            this.q6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q6Label.Location = new System.Drawing.Point(155, 3);
            this.q6Label.Name = "q6Label";
            this.q6Label.Size = new System.Drawing.Size(168, 26);
            this.q6Label.TabIndex = 0;
            this.q6Label.Text = "RSA Decryption";
            // 
            // HelpTab
            // 
            this.HelpTab.Controls.Add(this.HelpGenerateReportBtn);
            this.HelpTab.Controls.Add(this.helpTbox);
            this.HelpTab.Controls.Add(this.helpLabel);
            this.HelpTab.Location = new System.Drawing.Point(4, 25);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Size = new System.Drawing.Size(483, 249);
            this.HelpTab.TabIndex = 6;
            this.HelpTab.Text = "Help";
            this.HelpTab.UseVisualStyleBackColor = true;
            // 
            // HelpGenerateReportBtn
            // 
            this.HelpGenerateReportBtn.Location = new System.Drawing.Point(186, 222);
            this.HelpGenerateReportBtn.Name = "HelpGenerateReportBtn";
            this.HelpGenerateReportBtn.Size = new System.Drawing.Size(105, 23);
            this.HelpGenerateReportBtn.TabIndex = 2;
            this.HelpGenerateReportBtn.Text = "Generate Report";
            this.HelpGenerateReportBtn.UseVisualStyleBackColor = true;
            this.HelpGenerateReportBtn.Click += new System.EventHandler(this.HelpGenerateReportBtn_Click);
            // 
            // helpTbox
            // 
            this.helpTbox.Location = new System.Drawing.Point(8, 39);
            this.helpTbox.Name = "helpTbox";
            this.helpTbox.ReadOnly = true;
            this.helpTbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.helpTbox.Size = new System.Drawing.Size(467, 177);
            this.helpTbox.TabIndex = 1;
            this.helpTbox.Text = "";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpLabel.Location = new System.Drawing.Point(190, 3);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(99, 24);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Help Page";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 278);
            this.Controls.Add(this.MenuTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Maths Project - K00191419";
            this.MenuTabControl.ResumeLayout(false);
            this.Q1Tab.ResumeLayout(false);
            this.Q1Tab.PerformLayout();
            this.Q2Tab.ResumeLayout(false);
            this.Q2Tab.PerformLayout();
            this.Q3Tab.ResumeLayout(false);
            this.Q3Tab.PerformLayout();
            this.Q4Tab.ResumeLayout(false);
            this.Q4Tab.PerformLayout();
            this.Q5Tab.ResumeLayout(false);
            this.Q5Tab.PerformLayout();
            this.Q6Tab.ResumeLayout(false);
            this.Q6Tab.PerformLayout();
            this.HelpTab.ResumeLayout(false);
            this.HelpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuTabControl;
        private System.Windows.Forms.TabPage Q1Tab;
        private System.Windows.Forms.TabPage Q2Tab;
        private System.Windows.Forms.TabPage Q3Tab;
        private System.Windows.Forms.TabPage Q4Tab;
        private System.Windows.Forms.TabPage Q5Tab;
        private System.Windows.Forms.TabPage Q6Tab;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.Label q1Label;
        private System.Windows.Forms.Label q2Label;
        private System.Windows.Forms.Label q3Label;
        private System.Windows.Forms.Label q4Label;
        private System.Windows.Forms.Label q5Label;
        private System.Windows.Forms.Label q6Label;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button q1CheckMultipleBtn;
        private System.Windows.Forms.Button q1CheckPrimeBtn;
        private System.Windows.Forms.Label q1ResponseLabel;
        private System.Windows.Forms.Label q1EntNumLabel;
        private System.Windows.Forms.TextBox q1NumEntryTbx;
        private System.Windows.Forms.TextBox q2NumEntryTbx;
        private System.Windows.Forms.Label q2EnterNumLabel;
        private System.Windows.Forms.Button q2FactorizeMultpBtn;
        private System.Windows.Forms.Button q2FactorizeBtn;
        private System.Windows.Forms.RichTextBox q2ResultRTbx;
        private System.Windows.Forms.Button q3ComputeMultBtn;
        private System.Windows.Forms.Button q3CalcGcdBtn;
        private System.Windows.Forms.Label q3GcdOutLabel;
        private System.Windows.Forms.TextBox q3EntryBTbox;
        private System.Windows.Forms.TextBox q3EntryATbox;
        private System.Windows.Forms.Label q3EnterBLabel;
        private System.Windows.Forms.Label q3EnterALabel;
        private System.Windows.Forms.TextBox q4EntryBTbox;
        private System.Windows.Forms.TextBox q4EntryATbox;
        private System.Windows.Forms.Label q4EnterBLabel;
        private System.Windows.Forms.Label q4EnterALabel;
        private System.Windows.Forms.Button q4ComputeMultBtn;
        private System.Windows.Forms.Button q4Compute;
        private System.Windows.Forms.Label q4CoeffYLabel;
        private System.Windows.Forms.Label q4CoeffXLabel;
        private System.Windows.Forms.Label q4GcdLabel;
        private System.Windows.Forms.Label q4EqtnStaticLabel;
        private System.Windows.Forms.Button q5EncryptBtn;
        private System.Windows.Forms.TextBox q5CypherTbox;
        private System.Windows.Forms.Label q5CyphertxtLabel;
        private System.Windows.Forms.TextBox q5RsaModTbox;
        private System.Windows.Forms.TextBox q5EncrExpTbox;
        private System.Windows.Forms.Label q5RsaModLabel;
        private System.Windows.Forms.Label q5EncrExpLabel;
        private System.Windows.Forms.TextBox q5MsgEntryTbox;
        private System.Windows.Forms.Label q5MessageLabel;
        private System.Windows.Forms.Button q5GenerateKeysBtn;
        private System.Windows.Forms.Label q6PlainTxtLabel;
        private System.Windows.Forms.TextBox q6RsaModTbox;
        private System.Windows.Forms.TextBox q6DecryptExpTbox;
        private System.Windows.Forms.Label q6RsaModLabel;
        private System.Windows.Forms.Label q6DecryptExpLabel;
        private System.Windows.Forms.TextBox q6CypherTbox;
        private System.Windows.Forms.Label q6CypherLabel;
        private System.Windows.Forms.Button q6DecryptBtn;
        private System.Windows.Forms.TextBox q6PlainTxtTbox;
        private System.Windows.Forms.Button q6GenerateKeysBtn;
        private System.Windows.Forms.Label q2FactorListLabel;
        private System.Windows.Forms.TextBox q4YOutTbox;
        private System.Windows.Forms.TextBox q4XOutTbox;
        private System.Windows.Forms.TextBox q4GcdOutTbox;
        private System.Windows.Forms.TextBox q4EqtnOutTbox;
        private System.Windows.Forms.Button HelpGenerateReportBtn;
        private System.Windows.Forms.RichTextBox helpTbox;
    }
}

