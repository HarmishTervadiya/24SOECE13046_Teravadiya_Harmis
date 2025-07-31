namespace Tutorial5
{
    partial class P3
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
            this.Red = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Orange = new System.Windows.Forms.RadioButton();
            this.Yellow = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(175, 103);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(54, 20);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(357, 103);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(55, 20);
            this.Blue.TabIndex = 1;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(538, 103);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(65, 20);
            this.Green.TabIndex = 2;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Orange
            // 
            this.Orange.AutoSize = true;
            this.Orange.Location = new System.Drawing.Point(175, 175);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(73, 20);
            this.Orange.TabIndex = 3;
            this.Orange.TabStop = true;
            this.Orange.Text = "Orange";
            this.Orange.UseVisualStyleBackColor = true;
            this.Orange.CheckedChanged += new System.EventHandler(this.Orange_CheckedChanged);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.Location = new System.Drawing.Point(357, 175);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(68, 20);
            this.Yellow.TabIndex = 4;
            this.Yellow.TabStop = true;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Location = new System.Drawing.Point(538, 175);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(62, 20);
            this.Black.TabIndex = 5;
            this.Black.TabStop = true;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.CheckedChanged += new System.EventHandler(this.Black_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(157, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(157, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fore Color";
            // 
            // P3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "P3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.P2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Orange;
        private System.Windows.Forms.RadioButton Yellow;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}