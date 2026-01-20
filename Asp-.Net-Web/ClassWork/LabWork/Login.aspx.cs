using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork.LabWork
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\ClassWork\\App_Data\\Database1.mdf;Integrated Security=True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("Insert into login (username, password) values (@username, @password)",con);

            SqlCommand cmd = new SqlCommand("select username, password from login where username=@username AND password=@password", con); cmd.Parameters.AddWithValue("username", TextBox1.Text);
            cmd.Parameters.AddWithValue("password", TextBox2.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                Session["username"] = TextBox1.Text;


                HttpCookie usercookie = new HttpCookie("local");
                usercookie["usernmae"] = TextBox1.Text;

                Response.Redirect("FileUpload.aspx");
            }
            else
            {
                Response.Write("Username and password does not match");
            }

            con.Close();

        }
    }
}