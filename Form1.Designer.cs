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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTestEncryption = new System.Windows.Forms.Button();
            this.textBoxUserInputForEncryption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultOfEncryption = new System.Windows.Forms.TextBox();
            this.textBoxResultOfDecryption = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabIPInfoSearch.SuspendLayout();
            this.TabEncryptionTest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
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
            this.button1.Location = new System.Drawing.Point(648, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonTestEncryption
            // 
            this.buttonTestEncryption.Location = new System.Drawing.Point(627, 371);
            this.buttonTestEncryption.Name = "buttonTestEncryption";
            this.buttonTestEncryption.Size = new System.Drawing.Size(135, 23);
            this.buttonTestEncryption.TabIndex = 0;
            this.buttonTestEncryption.Text = "Test encryption";
            this.buttonTestEncryption.UseVisualStyleBackColor = true;
            this.buttonTestEncryption.Click += new System.EventHandler(this.buttonTestEncryption_Click);
            // 
            // textBoxUserInputForEncryption
            // 
            this.textBoxUserInputForEncryption.Location = new System.Drawing.Point(254, 66);
            this.textBoxUserInputForEncryption.Name = "textBoxUserInputForEncryption";
            this.textBoxUserInputForEncryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxUserInputForEncryption.TabIndex = 1;
            this.textBoxUserInputForEncryption.Text = "UserInput";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // textBoxResultOfEncryption
            // 
            this.textBoxResultOfEncryption.Location = new System.Drawing.Point(254, 106);
            this.textBoxResultOfEncryption.Name = "textBoxResultOfEncryption";
            this.textBoxResultOfEncryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxResultOfEncryption.TabIndex = 5;
            this.textBoxResultOfEncryption.Text = "result";
            // 
            // textBoxResultOfDecryption
            // 
            this.textBoxResultOfDecryption.Location = new System.Drawing.Point(254, 147);
            this.textBoxResultOfDecryption.Name = "textBoxResultOfDecryption";
            this.textBoxResultOfDecryption.Size = new System.Drawing.Size(172, 22);
            this.textBoxResultOfDecryption.TabIndex = 6;
            // 
            // FormGarthIPInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormGarthIPInfoSearch";
            this.Text = "Garth IP Info Search";
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
    }
}

