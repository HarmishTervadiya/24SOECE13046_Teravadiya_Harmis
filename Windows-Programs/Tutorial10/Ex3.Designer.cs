namespace Tutorial10
{
    partial class Ex3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQueryNo;
        private System.Windows.Forms.ComboBox cmbQueryNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvCustomerOrder;
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
            this.lblQueryNo = new System.Windows.Forms.Label();
            this.cmbQueryNo = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvCustomerOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQueryNo
            // 
            this.lblQueryNo.AutoSize = true;
            this.lblQueryNo.Location = new System.Drawing.Point(20, 20);
            this.lblQueryNo.Name = "lblQueryNo";
            this.lblQueryNo.Size = new System.Drawing.Size(65, 15);
            this.lblQueryNo.Text = "Query No.";
            // 
            // cmbQueryNo
            // 
            this.cmbQueryNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueryNo.FormattingEnabled = true;
            this.cmbQueryNo.Items.AddRange(new object[] {
                "1","2","3","4","5","6","7","8","9","10"});
            this.cmbQueryNo.Location = new System.Drawing.Point(100, 16);
            this.cmbQueryNo.Name = "cmbQueryNo";
            this.cmbQueryNo.Size = new System.Drawing.Size(121, 23);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(240, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvCustomerOrder
            // 
            this.dgvCustomerOrder.AllowUserToAddRows = false;
            this.dgvCustomerOrder.AllowUserToDeleteRows = false;
            this.dgvCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrder.Location = new System.Drawing.Point(20, 60);
            this.dgvCustomerOrder.Name = "dgvCustomerOrder";
            this.dgvCustomerOrder.ReadOnly = true;
            this.dgvCustomerOrder.Size = new System.Drawing.Size(740, 350);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCustomerOrder);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbQueryNo);
            this.Controls.Add(this.lblQueryNo);
            this.Name = "Form1";
            this.Text = "Customer Order Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            #endregion
        }
    }
}