using MVC_Practice.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Practice.DB_CODE
{
    public class StudentDB
    {
        public void insert(StudentModel s)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Asp-.Net-Web\\MVC-Practice\\App_Data\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into students values (@name, @email,@password)", con);
            cmd.Parameters.AddWithValue("name", s.name);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("password", s.password);

            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        public void update()
        {

        }

        public void delete()
        {

        }

        public void display()
        {

        }
    }
}