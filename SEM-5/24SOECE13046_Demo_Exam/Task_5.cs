using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24SOECE13046_Demo_Exam
{
    public partial class Task_5 : Form
    {
        int num1 = 0, num2 = 0;
        string op = "";

        public Task_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void EIGHT_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void NINE_BTN_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void FOUR_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void FIVE_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void SIX_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void ONE_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void TWO_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void THREE_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void ZERO_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void PLUS_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                num1 = Convert.ToInt32(richTextBox1.Text);
                op = "+";
                richTextBox1.Text = "";
            }
        }

        private void MINUS_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                num1 = Convert.ToInt32(richTextBox1.Text);
                op = "-";
                richTextBox1.Text = "";
            }
        }

        private void MUL_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                num1 = Convert.ToInt32(richTextBox1.Text);
                op = "*";
                richTextBox1.Text = "";
            }
        }

        private void DIV_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                num1 = Convert.ToInt32(richTextBox1.Text);
                op = "/";
                richTextBox1.Text = "";
            }
        }

        private void EQUAL_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                num2 = Convert.ToInt32(richTextBox1.Text);

                if (op == "+")
                {
                    richTextBox1.Text = (num1 + num2).ToString();
                }
                else if (op == "-")
                {
                    richTextBox1.Text = (num1 - num2).ToString();
                }
                else if (op == "*")
                {
                    richTextBox1.Text = (num1 * num2).ToString();
                }
                else if (op == "/")
                {
                    if (num2 != 0)
                        richTextBox1.Text = (num1 / num2).ToString();
                    else
                        richTextBox1.Text = "Error";
                }

                op = "";
            }
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            num1 = 0;
            num2 = 0;
            op = "";
        }
    }
}
