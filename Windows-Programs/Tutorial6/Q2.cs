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
    public partial class Q2 : Form
    {
        public Q2()
        {
            InitializeComponent();
        }

        private void Q2_Load(object sender, EventArgs e)
        {

        }

        private void Fill_BTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Education");
            listBox1.Items.Add("Sports");
            listBox1.Items.Add("Technology");
            listBox1.Items.Add("Books");
            listBox1.Items.Add("Investigation");
        }

        private void SORT_BTN_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void COUNT_BTN_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Items.Count.ToString();
        }

        private void RM_BTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
