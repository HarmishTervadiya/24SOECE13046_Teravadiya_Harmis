using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\Tanna-Sir-Class-Work\\LoanSiteDemo1\\App_Data\\Database.mdf;Integrated Security=True";
        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = @"INSERT INTO Loan
                            (AccountNo, LoanCategory, LoanType, Amount, CurrentAddress, LoanRemarks)
                             VALUES
                            (@AccountNo, @LoanCategory, @LoanType, @Amount, @CurrentAddress, @LoanRemarks)";

            SqlCommand cmd = new SqlCommand(query, con);

            
            cmd.Parameters.AddWithValue("@AccountNo", TextBox1.Text);
            cmd.Parameters.AddWithValue("@LoanCategory", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@LoanType", DropDownList2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@CurrentAddress", TextBox5.Text);
            cmd.Parameters.AddWithValue("@LoanRemarks", TextBox6.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            
            ClearForm();
        }
    }

    private void ClearForm()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
    }


}