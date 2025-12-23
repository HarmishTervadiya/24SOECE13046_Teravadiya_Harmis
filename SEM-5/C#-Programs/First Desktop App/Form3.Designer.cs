namespace First_Desktop_App
{
    partial class Form3
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
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SUB_BTN = new System.Windows.Forms.Button();
            this.MUL_BTN = new System.Windows.Forms.Button();
            this.DIV_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Location = new System.Drawing.Point(209, 175);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(75, 23);
            this.ADD_BTN.TabIndex = 11;
            this.ADD_BTN.Text = "+";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ENTER_BTN_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Num 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Num 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // SUB_BTN
            // 
            this.SUB_BTN.Location = new System.Drawing.Point(323, 175);
            this.SUB_BTN.Name = "SUB_BTN";
            this.SUB_BTN.Size = new System.Drawing.Size(75, 23);
            this.SUB_BTN.TabIndex = 12;
            this.SUB_BTN.Text = "-";
            this.SUB_BTN.UseVisualStyleBackColor = true;
            this.SUB_BTN.Click += new System.EventHandler(this.SUB_BTN_Click);
            // 
            // MUL_BTN
            // 
            this.MUL_BTN.Location = new System.Drawing.Point(424, 175);
            this.MUL_BTN.Name = "MUL_BTN";
            this.MUL_BTN.Size = new System.Drawing.Size(75, 23);
            this.MUL_BTN.TabIndex = 13;
            this.MUL_BTN.Text = "x";
            this.MUL_BTN.UseVisualStyleBackColor = true;
            this.MUL_BTN.Click += new System.EventHandler(this.MUL_BTN_Click);
            // 
            // DIV_BTN
            // 
            this.DIV_BTN.Location = new System.Drawing.Point(531, 175);
            this.DIV_BTN.Name = "DIV_BTN";
            this.DIV_BTN.Size = new System.Drawing.Size(75, 23);
            this.DIV_BTN.TabIndex = 14;
            this.DIV_BTN.Text = "/";
            this.DIV_BTN.UseVisualStyleBackColor = true;
            this.DIV_BTN.Click += new System.EventHandler(this.DIV_BTN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DIV_BTN);
            this.Controls.Add(this.MUL_BTN);
            this.Controls.Add(this.SUB_BTN);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SUB_BTN;
        private System.Windows.Forms.Button MUL_BTN;
        private System.Windows.Forms.Button DIV_BTN;
    }
}