using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial6
{
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "Invalid";
            if (radioButton1.Checked)
            {
                gender = "Mr";
            }

            if (radioButton1.Checked)
            {
                gender = "Miss";
            }

            string info = "";
            if (checkBox1.Checked)
            {
                info = info == "" ? checkBox1.Text : ", "+checkBox1.Text ; 
            }

            if (checkBox2.Checked)
            {
                info = info == "" ? checkBox2.Text : ", " + checkBox2.Text;
            }

            if (checkBox3.Checked)
            {
                info = info == "" ? checkBox3.Text : ", " + checkBox3.Text;
            }

            if (checkBox4.Checked)
            {
                info = info == "" ? checkBox4.Text : ", " + checkBox4.Text;
            }

            if (textBox2.Text != "")
            {
                info = info == "" ? textBox2.Text : ", " + textBox2.Text;
            }

            MSG_LABEL.Text = "Hello" + gender + textBox1.Text+ "You know about us from" + info;
            MSG_LABEL.Show();
        }
    }
}
