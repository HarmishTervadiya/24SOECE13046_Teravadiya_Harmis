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
        if (Session["user"] != null)
        {
            Response.Redirect("Home.aspx");
        }
    }

    protected void login_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\Tanna-Sir-Class-Work\\LoanSiteDemo1\\App_Data\\Database.mdf;Integrated Security=True";
            SqlConnection con= new SqlConnection(conString);
            con.Open();

            string query = "SELECT * FROM users WHERE userEmail = @email AND password = @password";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Session["User"] = TextBox1.Text;
                Response.Redirect("Home.aspx");
            }

            con.Close();
        }
    }
}