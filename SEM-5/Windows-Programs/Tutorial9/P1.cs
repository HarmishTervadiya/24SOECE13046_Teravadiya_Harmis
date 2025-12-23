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

namespace Tutorial9
{
    public partial class P1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial9\\Database1.mdf;Integrated Security=True";


        public P1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.database1DataSet1.Table1);
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void Insert_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table1 (name, course, dob, address, mob) VALUES (@name, @course, @dob, @address, @mob)", con);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.Parameters.AddWithValue("@dob", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@mob", Convert.ToInt32(textBox5.Text));

            
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Table1", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            MessageBox.Show("Added successfully");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Table1 where id=@id", con);
            cmd.Parameters.AddWithValue("@id",dataGridView1.SelectedCells[0].Value);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Table1", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            
        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Table1 SET name=@name, course=@course, dob=@dob, address=@address, mob=@mob WHERE id=@id", con);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.Parameters.AddWithValue("@dob", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@mob", Convert.ToInt32(textBox5.Text));
            cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedCells[0].Value);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Table1", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT * FROM Table1 WHERE name LIKE @name";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void View_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT * FROM Table1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
