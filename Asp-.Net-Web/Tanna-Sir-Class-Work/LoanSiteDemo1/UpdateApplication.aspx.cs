using System;
using System.Collections.Generic;
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\Tanna-Sir-Class-Work\\LoanSiteDemo1\\App_Data\\Database.mdf;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = @"SELECT L.*, A.actHolderName
                         FROM Loan L
                         INNER JOIN Account A
                         ON L.AccountNo = A.savingsActNo
                         WHERE L.LoanNo = @LoanNo";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LoanNo", TextBox7.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                TextBox1.Text = dr["AccountNo"].ToString();
                TextBox2.Text = dr["actHolderName"].ToString();
                DropDownList1.SelectedValue = dr["LoanCategory"].ToString();
                DropDownList2.SelectedValue = dr["LoanType"].ToString();
                TextBox4.Text = dr["Amount"].ToString();
                TextBox5.Text = dr["CurrentAddress"].ToString();
                TextBox6.Text = dr["LoanRemarks"].ToString();
            }

            con.Close();
        }
    }


    protected void submit_Click(object sender, EventArgs e)
    {
        string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\Tanna-Sir-Class-Work\\LoanSiteDemo1\\App_Data\\Database.mdf;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = @"UPDATE Loan SET
                        AccountNo = @AccountNo,
                        LoanCategory = @LoanCategory,
                        LoanType = @LoanType,
                        Amount = @Amount,
                        CurrentAddress = @CurrentAddress,
                        LoanRemarks = @LoanRemarks
                        WHERE LoanNo = @LoanNo";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@AccountNo", TextBox1.Text);
            cmd.Parameters.AddWithValue("@LoanCategory", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@LoanType", DropDownList2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@CurrentAddress", TextBox5.Text);
            cmd.Parameters.AddWithValue("@LoanRemarks", TextBox6.Text);
            cmd.Parameters.AddWithValue("@LoanNo", TextBox7.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Label2.Text = "Loan Application Updated Successfully";
            Label2.Visible = true;

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
        TextBox7.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}