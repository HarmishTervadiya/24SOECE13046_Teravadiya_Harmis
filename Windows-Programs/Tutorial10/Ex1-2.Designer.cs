namespace Tutorial10
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();

            // Inputs
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.cboCustomerId = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.cboPaymentMode = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();

            // Buttons
            this.btnView = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button(); // optional (same as Search)
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            // DataGridView
            this.dgvOrders = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();

            // --- Label properties ---
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(20, 20);
            this.lblOrderId.Text = "Order ID";

            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(20, 60);
            this.lblCustomerId.Text = "Customer ID";

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 100);
            this.lblCustomerName.Text = "Customer Name";

            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(20, 140);
            this.lblOrderDate.Text = "Order Date";

            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(20, 180);
            this.lblShipDate.Text = "Ship Date";

            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.Location = new System.Drawing.Point(20, 220);
            this.lblOrderAmount.Text = "Order Amount";

            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(20, 260);
            this.lblPaymentMode.Text = "Payment Mode";

            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(20, 300);
            this.lblRemarks.Text = "Remarks";

            // --- Inputs ---
            this.txtOrderId.Location = new System.Drawing.Point(150, 18);
            this.txtOrderId.Width = 120;
            this.txtOrderId.Name = "txtOrderId"; // used for search/edit

            this.cboCustomerId.Location = new System.Drawing.Point(150, 58);
            this.cboCustomerId.Width = 120;
            this.cboCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerId.Name = "cboCustomerId";

            this.txtCustomerName.Location = new System.Drawing.Point(150, 98);
            this.txtCustomerName.Width = 220;
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Name = "txtCustomerName";

            this.dtpOrderDate.Location = new System.Drawing.Point(150, 138);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Name = "dtpOrderDate";

            this.dtpShipDate.Location = new System.Drawing.Point(150, 178);
            this.dtpShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShipDate.Name = "dtpShipDate";

            this.txtOrderAmount.Location = new System.Drawing.Point(150, 218);
            this.txtOrderAmount.Width = 120;
            this.txtOrderAmount.Name = "txtOrderAmount";

            this.cboPaymentMode.Location = new System.Drawing.Point(150, 258);
            this.cboPaymentMode.Width = 150;
            this.cboPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMode.Items.AddRange(new object[] { "UPI", "RuPay Cards", "Debit Cards", "NetBanking", "Wallet" });
            this.cboPaymentMode.Name = "cboPaymentMode";

            this.txtRemarks.Location = new System.Drawing.Point(150, 298);
            this.txtRemarks.Width = 300;
            this.txtRemarks.Name = "txtRemarks";

            // --- Buttons ---
            this.btnView.Text = "View";
            this.btnView.Location = new System.Drawing.Point(20, 340);
            this.btnView.Size = new System.Drawing.Size(60, 28);
            this.btnView.Name = "btnView";

            this.btnNew.Text = "New";
            this.btnNew.Location = new System.Drawing.Point(90, 340);
            this.btnNew.Size = new System.Drawing.Size(60, 28);
            this.btnNew.Name = "btnNew";

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(160, 340);
            this.btnSave.Size = new System.Drawing.Size(60, 28);
            this.btnSave.Name = "btnSave";

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(230, 340);
            this.btnClear.Size = new System.Drawing.Size(60, 28);
            this.btnClear.Name = "btnClear";

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(300, 340);
            this.btnEdit.Size = new System.Drawing.Size(60, 28);
            this.btnEdit.Name = "btnEdit";

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(370, 340);
            this.btnUpdate.Size = new System.Drawing.Size(60, 28);
            this.btnUpdate.Name = "btnUpdate";

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(440, 340);
            this.btnDelete.Size = new System.Drawing.Size(60, 28);
            this.btnDelete.Name = "btnDelete";

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(280, 16);
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.Name = "btnSearch";

            // --- DataGridView ---
            this.dgvOrders.Location = new System.Drawing.Point(20, 380);
            this.dgvOrders.Size = new System.Drawing.Size(760, 220);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.Name = "dgvOrders";

            // --- Add controls to form ---
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblShipDate);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.lblRemarks);

            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.cboCustomerId);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.dtpShipDate);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.cboPaymentMode);
            this.Controls.Add(this.txtRemarks);

            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);

            this.Controls.Add(this.dgvOrders);

            this.Text = "Order Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // --- Event wiring ---
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cboCustomerId.SelectedIndexChanged += new System.EventHandler(this.cboCustomerId_SelectedIndexChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblOrderId, lblCustomerId, lblCustomerName, lblOrderDate,
            lblShipDate, lblOrderAmount, lblPaymentMode, lblRemarks;

        private System.Windows.Forms.TextBox txtOrderId, txtCustomerName, txtOrderAmount, txtRemarks;
        private System.Windows.Forms.ComboBox cboCustomerId, cboPaymentMode;
        private System.Windows.Forms.DateTimePicker dtpOrderDate, dtpShipDate;
        private System.Windows.Forms.Button btnView, btnNew, btnSave, btnClear, btnEdit, btnUpdate, btnDelete, btnSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
    

    }
}

