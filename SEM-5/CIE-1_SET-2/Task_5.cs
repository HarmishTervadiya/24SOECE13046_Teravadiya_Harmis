using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIE_1_SET_2
{
    public partial class Task_5 : Form
    {
        public Task_5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans = 0;
            string op="";

            if (Add_BTN.Checked)
            {
                ans = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                op = "Addition";
            }
            else if (SUB_BTN.Checked)
            {
                ans = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                op = "Substraction";
            }
            else if(MUL_BTN.Checked)
            {
                ans = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                op = "Multiplication";

            }else if (DIV_BTN.Checked)
            {
                ans = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                op = "Division";
            }
            else
            {
                ans = 0;
            }

            label3.Text = textBox1.Text +" and " + " "+ textBox2.Text + op + " is " + ans;
            label3.Show();
        }
    }
}
