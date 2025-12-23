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
    public partial class Task_4 : Form
    {
        public Task_4()
        {
            InitializeComponent();
        }

        private void Task_4_Load(object sender, EventArgs e)
        {

        }

        

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void Black_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor.ForeColor = Color.Black;
            
        }

        private void White_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor.ForeColor = Color.White;

        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor.ForeColor = Color.Red;
        }

        private void d_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        
    }
}
