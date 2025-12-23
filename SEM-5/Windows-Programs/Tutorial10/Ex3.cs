using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial10
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial10\\Database1.mdf;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbQueryNo.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbQueryNo.SelectedItem == null) return;

            int queryNo = Convert.ToInt32(cmbQueryNo.SelectedItem);
            string query = "";

            switch (queryNo)
            {
                case 1:
                    query = @"SELECT o.OrderID, o.CUSTID, c.Name, c.City, c.State, o.OrderAmount 
                              FROM Customers c, Orders o 
                              WHERE c.ID = o.CUSTID";
                    break;
                case 2:
                    query = @"SELECT o.OrderID, o.CustID, c.Name, c.City, c.State, o.OrderAmount 
                              FROM Customers c, Orders o 
                              WHERE c.ID = o.CustID AND o.OrderAmount > 10000";
                    break;
                case 3:
                    query = @"SELECT c.ID, c.Name, SUM(o.OrderAmount) AS TotalOrderAmount
                              FROM Customers c 
                              JOIN Orders o ON c.ID = o.CustID
                              GROUP BY c.ID, c.Name";
                    break;
                case 4:
                    query = @"SELECT c.ID, c.Name, 
                                     DATENAME(MONTH, o.OrderDate) AS OrderMonth, 
                                     YEAR(o.OrderDate) AS OrderYear, 
                                     SUM(o.OrderAmount) AS TotalAmount
                              FROM Customers c
                              JOIN Orders o ON c.ID = o.CustID
                              GROUP BY c.ID, c.Name, DATENAME(MONTH, o.OrderDate), YEAR(o.OrderDate)";
                    break;
                case 5:
                    query = @"SELECT o.PaymentMode, SUM(o.OrderAmount) AS TotalAmount
                              FROM Orders o
                              GROUP BY o.PaymentMode";
                    break;
                case 6:
                    query = @"SELECT o.PaymentMode, SUM(o.OrderAmount) AS TotalAmount
                              FROM Orders o
                              WHERE YEAR(o.OrderDate) = YEAR(GETDATE())
                              GROUP BY o.PaymentMode";
                    break;
                case 7:
                    query = @"SELECT o.PaymentMode, SUM(o.OrderAmount) AS TotalAmount
                              FROM Orders o
                              WHERE YEAR(o.OrderDate) = YEAR(GETDATE()) - 1
                              GROUP BY o.PaymentMode";
                    break;
                case 8:
                    query = @"SELECT o.PaymentMode, SUM(o.OrderAmount) AS TotalAmount
                              FROM Orders o
                              WHERE o.OrderDate BETWEEN '2024-01-01' AND '2024-12-31'
                              GROUP BY o.PaymentMode";
                    break;
                case 9:
                    query = @"SELECT TOP 5 c.ID, c.Name, SUM(o.OrderAmount) AS TotalSpent
                              FROM Customers c
                              JOIN Orders o ON c.ID = o.CustID
                              GROUP BY c.ID, c.Name
                              ORDER BY TotalSpent DESC";
                    break;
                case 10:
                    query = @"SELECT o.OrderID, c.Name, o.OrderAmount, o.PaymentMode
                              FROM Orders o
                              JOIN Customers c ON o.CustID = c.ID
                              WHERE o.Remarks IS NULL OR o.Remarks = ''";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvCustomerOrder.DataSource = ds.Tables[0];
                }
            }

        }
    }
}
