namespace WIndows_Programs
{
    partial class Form1
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
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.BRANCH_TXT = new System.Windows.Forms.TextBox();
            this.CITY_TXT = new System.Windows.Forms.TextBox();
            this.PWD_TXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GENDER_BOX = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(322, 122);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(191, 22);
            this.NAME_TXT.TabIndex = 0;
            this.NAME_TXT.TextChanged += new System.EventHandler(this.NAME_TXT_TextChanged);
            // 
            // BRANCH_TXT
            // 
            this.BRANCH_TXT.Location = new System.Drawing.Point(322, 173);
            this.BRANCH_TXT.Name = "BRANCH_TXT";
            this.BRANCH_TXT.Size = new System.Drawing.Size(191, 22);
            this.BRANCH_TXT.TabIndex = 1;
            this.BRANCH_TXT.TextChanged += new System.EventHandler(this.BRANCH_TXT_TextChanged);
            // 
            // CITY_TXT
            // 
            this.CITY_TXT.Location = new System.Drawing.Point(322, 227);
            this.CITY_TXT.Name = "CITY_TXT";
            this.CITY_TXT.Size = new System.Drawing.Size(191, 22);
            this.CITY_TXT.TabIndex = 2;
            // 
            // PWD_TXT
            // 
            this.PWD_TXT.Location = new System.Drawing.Point(322, 316);
            this.PWD_TXT.Name = "PWD_TXT";
            this.PWD_TXT.PasswordChar = '*';
            this.PWD_TXT.Size = new System.Drawing.Size(191, 22);
            this.PWD_TXT.TabIndex = 3;
            this.PWD_TXT.TextChanged += new System.EventHandler(this.PWD_TXT_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Branch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 270);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(399, 270);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // GENDER_BOX
            // 
            this.GENDER_BOX.Location = new System.Drawing.Point(322, 256);
            this.GENDER_BOX.Name = "GENDER_BOX";
            this.GENDER_BOX.Size = new System.Drawing.Size(191, 54);
            this.GENDER_BOX.TabIndex = 12;
            this.GENDER_BOX.TabStop = false;
            this.GENDER_BOX.Enter += new System.EventHandler(this.GENDER_BOX_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PWD_TXT);
            this.Controls.Add(this.CITY_TXT);
            this.Controls.Add(this.BRANCH_TXT);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.GENDER_BOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.TextBox BRANCH_TXT;
        private System.Windows.Forms.TextBox CITY_TXT;
        private System.Windows.Forms.TextBox PWD_TXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox GENDER_BOX;
    }
}

