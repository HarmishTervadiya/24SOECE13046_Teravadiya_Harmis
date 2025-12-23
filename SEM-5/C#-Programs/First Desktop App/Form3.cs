using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Desktop_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ENTER_BTN_Click_1(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text.ToString()) + Convert.ToInt32(textBox2.Text.ToString());
            MessageBox.Show("Sum is " + sum);

        }

        private void SUB_BTN_Click(object sender, EventArgs e)
        {
            int sub = Convert.ToInt32(textBox1.Text.ToString()) - Convert.ToInt32(textBox2.Text.ToString());
            MessageBox.Show("Substraction is " + sub);

        }

        private void MUL_BTN_Click(object sender, EventArgs e)
        {
            int mul = Convert.ToInt32(textBox1.Text.ToString()) * Convert.ToInt32(textBox2.Text.ToString());
            MessageBox.Show("Multiplication is " + mul);

        }

        private void DIV_BTN_Click(object sender, EventArgs e)
        {
            int div = Convert.ToInt32(textBox1.Text.ToString()) / Convert.ToInt32(textBox2.Text.ToString());
            MessageBox.Show("Division is " + div);

        }
    }
}
