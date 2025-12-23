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
    public partial class P2 : Form
    {
        public P2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\Tutorial9\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student WHERE name LIKE @name", con);
            adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
    }
}
