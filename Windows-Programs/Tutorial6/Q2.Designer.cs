namespace Tutorial6
{
    partial class Q2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fill_BTN = new System.Windows.Forms.Button();
            this.SORT_BTN = new System.Windows.Forms.Button();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.RM_BTN = new System.Windows.Forms.Button();
            this.COUNT_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(56, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 116);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Fill_BTN
            // 
            this.Fill_BTN.Location = new System.Drawing.Point(227, 82);
            this.Fill_BTN.Name = "Fill_BTN";
            this.Fill_BTN.Size = new System.Drawing.Size(75, 23);
            this.Fill_BTN.TabIndex = 2;
            this.Fill_BTN.Text = "Fill";
            this.Fill_BTN.UseVisualStyleBackColor = true;
            this.Fill_BTN.Click += new System.EventHandler(this.Fill_BTN_Click);
            // 
            // SORT_BTN
            // 
            this.SORT_BTN.Location = new System.Drawing.Point(227, 128);
            this.SORT_BTN.Name = "SORT_BTN";
            this.SORT_BTN.Size = new System.Drawing.Size(75, 23);
            this.SORT_BTN.TabIndex = 3;
            this.SORT_BTN.Text = "Sort";
            this.SORT_BTN.UseVisualStyleBackColor = true;
            this.SORT_BTN.Click += new System.EventHandler(this.SORT_BTN_Click);
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.Location = new System.Drawing.Point(227, 172);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(75, 23);
            this.CLEAR_BTN.TabIndex = 4;
            this.CLEAR_BTN.Text = "Clear";
            this.CLEAR_BTN.UseVisualStyleBackColor = true;
            this.CLEAR_BTN.Click += new System.EventHandler(this.CLEAR_BTN_Click);
            // 
            // RM_BTN
            // 
            this.RM_BTN.Location = new System.Drawing.Point(185, 240);
            this.RM_BTN.Name = "RM_BTN";
            this.RM_BTN.Size = new System.Drawing.Size(169, 23);
            this.RM_BTN.TabIndex = 5;
            this.RM_BTN.Text = "Remove Items";
            this.RM_BTN.UseVisualStyleBackColor = true;
            this.RM_BTN.Click += new System.EventHandler(this.RM_BTN_Click);
            // 
            // COUNT_BTN
            // 
            this.COUNT_BTN.Location = new System.Drawing.Point(56, 240);
            this.COUNT_BTN.Name = "COUNT_BTN";
            this.COUNT_BTN.Size = new System.Drawing.Size(75, 23);
            this.COUNT_BTN.TabIndex = 6;
            this.COUNT_BTN.Text = "Count";
            this.COUNT_BTN.UseVisualStyleBackColor = true;
            this.COUNT_BTN.Click += new System.EventHandler(this.COUNT_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Display total count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your selection";
            // 
            // Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COUNT_BTN);
            this.Controls.Add(this.RM_BTN);
            this.Controls.Add(this.CLEAR_BTN);
            this.Controls.Add(this.SORT_BTN);
            this.Controls.Add(this.Fill_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Q2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Q2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Fill_BTN;
        private System.Windows.Forms.Button SORT_BTN;
        private System.Windows.Forms.Button CLEAR_BTN;
        private System.Windows.Forms.Button RM_BTN;
        private System.Windows.Forms.Button COUNT_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}