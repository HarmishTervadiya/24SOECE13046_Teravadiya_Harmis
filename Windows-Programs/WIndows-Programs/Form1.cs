using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WIndows_Programs
{
    public partial class Form1 : Form
    {
        string name, branch, city, gender, password;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\Windows-Programs\\WIndows-Programs\\Student_DB.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void NAME_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BRANCH_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GENDER_BOX_Enter(object sender, EventArgs e)
        {

        }

        private void PWD_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = NAME_TXT.Text.ToString();
            branch = BRANCH_TXT.Text.ToString();
            city = BRANCH_TXT.Text.ToString();
            password = PWD_TXT.Text.ToString();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "insert into Student_DB values('"+name+ "', '"+branch+ "', '"+city+ "', '"+gender+ "', '"+password+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Registered successfully");
        }
    }
}
