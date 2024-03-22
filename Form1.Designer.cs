namespace WindowsFormsApp1
{
    partial class FormGarthIPInfoSearch
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabIPInfoSearch = new System.Windows.Forms.TabPage();
            this.ButtonIPInfoSearch = new System.Windows.Forms.Button();
            this.TabEncryptionTest = new System.Windows.Forms.TabPage();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.textBoxResultOfDecryption = new System.Windows.Forms.TextBox();
            this.textBoxResultOfEncryption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserInputForEncryption = new System.Windows.Forms.TextBox();
            this.buttonTestEncryption = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabIPInfoSearch.SuspendLayout();
            this.TabEncryptionTest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabIPInfoSearch);
            this.tabControl1.Controls.Add(this.TabEncryptionTest);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabIPInfoSearch
            // 
            this.TabIPInfoSearch.Controls.Add(this.ButtonIPInfoSearch);
            this.TabIPInfoSearch.Location = new System.Drawing.Point(4, 22);
            this.TabIPInfoSearch.Name = "TabIPInfoSearch";
            this.TabIPInfoSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TabIPInfoSearch.Size = new System.Drawing.Size(768, 400);
            this.TabIPInfoSearch.TabIndex = 0;
            this.TabIPInfoSearch.Text = "IP info Search";
            this.TabIPInfoSearch.UseVisualStyleBackColor = true;
            this.TabIPInfoSearch.Click += new System.EventHandler(this.TabIPInfoSearch_Click);
            // 
            // ButtonIPInfoSearch
            // 
            this.ButtonIPInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonIPInfoSearch.Location = new System.Drawing.Point(644, 371);
            this.ButtonIPInfoSearch.Name = "ButtonIPInfoSearch";
            this.ButtonIPInfoSearch.Size = new System.Drawing.Size(118, 23);
            this.ButtonIPInfoSearch.TabIndex = 0;
            this.ButtonIPInfoSearch.Text = "IP Info Search";
            this.ButtonIPInfoSearch.UseVisualStyleBackColor = true;
            // 
            // TabEncryptionTest
            // 
            this.TabEncryptionTest.Controls.Add(this.buttonDecryption);
            this.TabEncryptionTest.Controls.Add(this.textBoxResultOfDecryption);
            this.TabEncryptionTest.Controls.Add(this.textBoxResultOfEncryption);
            this.TabEncryptionTest.Controls.Add(this.label3);
            this.TabEncryptionTest.Controls.Add(this.label2);
            this.TabEncryptionTest.Controls.Add(this.label1);
            this.TabEncryptionTest.Controls.Add(this.textBoxUserInputForEncryption);
            this.TabEncryptionTest.Controls.Add(this.buttonTestEncryption);
            this.TabEncryptionTest.Location = new System.Drawing.Point(4, 22);
            this.TabEncryptionTest.Name = "TabEncryptionTest";
            this.TabEncryptionTest.Padding = new System.Windows.Forms.Padding(3);
            this.TabEncryptionTest.Size = new System.Drawing.Size(768, 400);
            this.TabEncryptionTest.TabIndex = 1;
            this.TabEncryptionTest.Text = "Encryption Test";
            this.TabEncryptionTest.UseVisualStyleBackColor = true;
            this.TabEncryptionTest.Click += new System.EventHandler(this.TabEncryptionTest_Click);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecryption.Location = new System.Drawing.Point(471, 371);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(119, 23);
            this.buttonDecryption.TabIndex = 7;
            this.buttonDecryption.Text = "Deryption";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxResultOfDecryption
            // 
            this.textBoxResultOfDecryption.Location = new System.Drawing.Point(254, 255);
            this.textBoxResultOfDecryption.Name = "textBoxResultOfDecryption";
            this.textBoxResultOfDecryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxResultOfDecryption.TabIndex = 6;
            this.textBoxResultOfDecryption.Text = "decryption result";
            this.textBoxResultOfDecryption.TextChanged += new System.EventHandler(this.textBoxResultOfDecryption_TextChanged);
            // 
            // textBoxResultOfEncryption
            // 
            this.textBoxResultOfEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultOfEncryption.Location = new System.Drawing.Point(254, 178);
            this.textBoxResultOfEncryption.Name = "textBoxResultOfEncryption";
            this.textBoxResultOfEncryption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResultOfEncryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxResultOfEncryption.TabIndex = 5;
            this.textBoxResultOfEncryption.Text = "encryption result";
            this.textBoxResultOfEncryption.TextChanged += new System.EventHandler(this.textBoxResultOfEncryption_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(254, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBoxUserInputForEncryption
            // 
            this.textBoxUserInputForEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserInputForEncryption.Location = new System.Drawing.Point(254, 98);
            this.textBoxUserInputForEncryption.Name = "textBoxUserInputForEncryption";
            this.textBoxUserInputForEncryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxUserInputForEncryption.TabIndex = 1;
            this.textBoxUserInputForEncryption.Text = "Please Insert Eight Letters";
            // 
            // buttonTestEncryption
            // 
            this.buttonTestEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestEncryption.Location = new System.Drawing.Point(627, 371);
            this.buttonTestEncryption.Name = "buttonTestEncryption";
            this.buttonTestEncryption.Size = new System.Drawing.Size(135, 23);
            this.buttonTestEncryption.TabIndex = 0;
            this.buttonTestEncryption.Text = "Encryption";
            this.buttonTestEncryption.UseVisualStyleBackColor = true;
            this.buttonTestEncryption.Click += new System.EventHandler(this.buttonTestEncryption_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(687, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormGarthIPInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormGarthIPInfoSearch";
            this.Text = "Garth IP Info Search";
            this.Load += new System.EventHandler(this.FormGarthIPInfoSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabIPInfoSearch.ResumeLayout(false);
            this.TabEncryptionTest.ResumeLayout(false);
            this.TabEncryptionTest.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabIPInfoSearch;
        private System.Windows.Forms.TabPage TabEncryptionTest;
        private System.Windows.Forms.Button ButtonIPInfoSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResultOfDecryption;
        private System.Windows.Forms.TextBox textBoxResultOfEncryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserInputForEncryption;
        private System.Windows.Forms.Button buttonTestEncryption;
        private System.Windows.Forms.Button buttonDecryption;
    }
}

