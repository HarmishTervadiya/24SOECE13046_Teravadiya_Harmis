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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial10\\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * from donations",con);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
           
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.donationsTableAdapter.Fill(this.database1DataSet.donations);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial10\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Update donations set name=@name, type=@type where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("name", textBox1.Text);
            cmd.Parameters.AddWithValue("type", textBox2.Text);
            cmd.Parameters.AddWithValue("id", textBox3.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Updated succesfully");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial10\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Delete from donations where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("id", textBox3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Deleted succesfully");
            con.Close();
        }
    }
}
