using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tutorial10
{
    public partial class Form1 : Form
    {
        private string connectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial10\\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
            LoadOrdersToGrid();
            ResetForm();
        }


        private void ResetForm()
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtOrderAmount.Clear();
            txtRemarks.Clear();
            cboPaymentMode.SelectedIndex = -1;
            cboCustomerId.SelectedIndex = -1;

            dtpOrderDate.Value = DateTime.Today;
            dtpShipDate.Value = DateTime.Today;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadCustomerList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name FROM [Table] ORDER BY Id", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboCustomerId.DataSource = dt;
                cboCustomerId.DisplayMember = "Id";
                cboCustomerId.ValueMember = "Id";
                cboCustomerId.SelectedIndex = -1;
            }
        }

        private void LoadOrdersToGrid()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = @"SELECT OrderID, CUSTID,
                              (SELECT Name FROM [Table] WHERE Id = o.CUSTID) AS CustomerName,
                              OrderDate, ShipDate, OrderAmount, PaymentMode, Remarks
                              FROM orders o
                              ORDER BY OrderID";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }
        }

        private void FillOrderForm(int orderId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM orders WHERE OrderID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtOrderId.Text = rdr["OrderID"].ToString();
                    int custId = Convert.ToInt32(rdr["CUSTID"]);
                    cboCustomerId.SelectedValue = custId;

                    txtOrderAmount.Text = rdr["OrderAmount"].ToString();
                    cboPaymentMode.SelectedItem = rdr["PaymentMode"].ToString();
                    txtRemarks.Text = rdr["Remarks"].ToString();

                    if (DateTime.TryParse(rdr["OrderDate"].ToString(), out DateTime od))
                        dtpOrderDate.Value = od;
                    if (DateTime.TryParse(rdr["ShipDate"].ToString(), out DateTime sd))
                        dtpShipDate.Value = sd;

                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Order not found.");
                }
            }
        }


        private void cboCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerId.SelectedItem is DataRowView row)
            {
                txtCustomerName.Text = row["Name"].ToString();
            }
            else
            {
                txtCustomerName.Clear();
            }
        }

        private void btnNew_Click(object sender, EventArgs e) => ResetForm();

        private void btnClear_Click(object sender, EventArgs e) => ResetForm();

        private void btnView_Click(object sender, EventArgs e) => LoadOrdersToGrid();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCustomerId.SelectedValue == null)
            {
                MessageBox.Show("Select Customer ID.");
                return;
            }
            if (!int.TryParse(txtOrderAmount.Text.Trim(), out int amount))
            {
                MessageBox.Show("Enter valid numeric amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO orders (CUSTID, OrderDate, ShipDate, OrderAmount, PaymentMode, Remarks) " +
                "VALUES (@cid, @od, @sd, @amt, @pm, @rem)", con))
            {
                cmd.Parameters.AddWithValue("@cid", cboCustomerId.SelectedValue);
                cmd.Parameters.AddWithValue("@od", dtpOrderDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sd", dtpShipDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@amt", amount);
                cmd.Parameters.AddWithValue("@pm", cboPaymentMode.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@rem", txtRemarks.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Order saved.");
                    LoadOrdersToGrid();
                    ResetForm();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtOrderId.Text.Trim(), out int orderId))
                FillOrderForm(orderId);
            else
                MessageBox.Show("Enter valid Order ID.");
        }

        private void btnEdit_Click(object sender, EventArgs e) => btnSearch.PerformClick();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderId.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }
            if (cboCustomerId.SelectedValue == null)
            {
                MessageBox.Show("Select Customer ID.");
                return;
            }
            if (!int.TryParse(txtOrderAmount.Text.Trim(), out int amount))
            {
                MessageBox.Show("Enter valid numeric amount.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE orders SET 
                    CUSTID=@cid, OrderDate=@od, ShipDate=@sd, 
                    OrderAmount=@amt, PaymentMode=@pm, Remarks=@rem 
                  WHERE OrderID=@id", con))
            {
                cmd.Parameters.AddWithValue("@cid", cboCustomerId.SelectedValue);
                cmd.Parameters.AddWithValue("@od", dtpOrderDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sd", dtpShipDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@amt", amount);
                cmd.Parameters.AddWithValue("@pm", cboPaymentMode.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@rem", txtRemarks.Text.Trim());
                cmd.Parameters.AddWithValue("@id", orderId);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Order updated.");
                    LoadOrdersToGrid();
                    ResetForm();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderId.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Enter valid Order ID.");
                return;
            }

            var confirm = MessageBox.Show($"Delete Order {orderId}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM orders WHERE OrderID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Order deleted.");
                    LoadOrdersToGrid();
                    ResetForm();
                }
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null)
            {
                int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                FillOrderForm(orderId);
            }
        }
    }
}
