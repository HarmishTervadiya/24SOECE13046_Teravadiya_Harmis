using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class P1 : Form
    {
        public P1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "Welcome to first app Harmis";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void P1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + textBox1.Text + " from " + textBox2.Text + " is " + textBox3.Text);
        }
    }
}
