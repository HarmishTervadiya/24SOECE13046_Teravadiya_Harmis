namespace CIE_1_SET_2
{
    partial class Task_4
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
            System.Windows.Forms.GroupBox BackColorGroup;
            this.d = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.FRed = new System.Windows.Forms.RadioButton();
            this.FWhite = new System.Windows.Forms.RadioButton();
            this.FBlack = new System.Windows.Forms.RadioButton();
            this.ForeColor = new System.Windows.Forms.GroupBox();
            BackColorGroup = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // BackColorGroup
            // 
            BackColorGroup.Location = new System.Drawing.Point(79, 54);
            BackColorGroup.Name = "BackColorGroup";
            BackColorGroup.Size = new System.Drawing.Size(463, 100);
            BackColorGroup.TabIndex = 6;
            BackColorGroup.TabStop = false;
            BackColorGroup.Text = "Back Color";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(115, 98);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(54, 20);
            this.d.TabIndex = 0;
            this.d.TabStop = true;
            this.d.Text = "Red";
            this.d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d.UseVisualStyleBackColor = true;
            this.d.CheckedChanged += new System.EventHandler(this.d_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(255, 98);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(65, 20);
            this.Green.TabIndex = 1;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(385, 98);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(55, 20);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // FRed
            // 
            this.FRed.AutoSize = true;
            this.FRed.Location = new System.Drawing.Point(385, 233);
            this.FRed.Name = "FRed";
            this.FRed.Size = new System.Drawing.Size(54, 20);
            this.FRed.TabIndex = 5;
            this.FRed.TabStop = true;
            this.FRed.Text = "Red";
            this.FRed.UseVisualStyleBackColor = true;
            this.FRed.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // FWhite
            // 
            this.FWhite.AutoSize = true;
            this.FWhite.Location = new System.Drawing.Point(255, 233);
            this.FWhite.Name = "FWhite";
            this.FWhite.Size = new System.Drawing.Size(62, 20);
            this.FWhite.TabIndex = 4;
            this.FWhite.TabStop = true;
            this.FWhite.Text = "White";
            this.FWhite.UseVisualStyleBackColor = true;
            this.FWhite.CheckedChanged += new System.EventHandler(this.White_CheckedChanged);
            // 
            // FBlack
            // 
            this.FBlack.AutoSize = true;
            this.FBlack.Location = new System.Drawing.Point(115, 233);
            this.FBlack.Name = "FBlack";
            this.FBlack.Size = new System.Drawing.Size(62, 20);
            this.FBlack.TabIndex = 3;
            this.FBlack.TabStop = true;
            this.FBlack.Text = "Black";
            this.FBlack.UseVisualStyleBackColor = true;
            this.FBlack.CheckedChanged += new System.EventHandler(this.Black_CheckedChanged);
            // 
            // ForeColor
            // 
            this.ForeColor.Location = new System.Drawing.Point(79, 193);
            this.ForeColor.Name = "ForeColor";
            this.ForeColor.Size = new System.Drawing.Size(463, 100);
            this.ForeColor.TabIndex = 7;
            this.ForeColor.TabStop = false;
            this.ForeColor.Text = "Fore Color";
            // 
            // Task_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FRed);
            this.Controls.Add(this.FWhite);
            this.Controls.Add(this.FBlack);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.d);
            this.Controls.Add(this.ForeColor);
            this.Controls.Add(BackColorGroup);
            this.Name = "Task_4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Task_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton FRed;
        private System.Windows.Forms.RadioButton FWhite;
        private System.Windows.Forms.RadioButton FBlack;
        private System.Windows.Forms.GroupBox ForeColor;
    }
}

