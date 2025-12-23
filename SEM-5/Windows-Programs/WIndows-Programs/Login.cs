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

namespace WIndows_Programs
{
    public partial class Login : Form
    {

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\WIndows-Programs\\Student_DB.mdf;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO login(email, password) VALUES(@email, @password)", con);

            cmd.Parameters.AddWithValue("@email", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@password", textBox2.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("update login set email=@email, password=@password where id=@id", con);

            cmd.Parameters.AddWithValue("@email", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@password", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@id", textBox3.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully");
        }
    }
}
