using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Desktop_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double num1, num2, result;
        string operand= "";

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text=="0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.AppendText("0");
            }

        }


        private void BTN_1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.AppendText("1");
            }
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.AppendText("2");
            }
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.AppendText("3");
            }
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.AppendText("4");
            }
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.AppendText("5");
            }
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.AppendText("6");
            }
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.AppendText("7");
            }
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.AppendText("8");
            }
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.AppendText("9");
            }
        }

        private void BTN_DIV_Click(object sender, EventArgs e)
        {
            num1= Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operand = "/";
        }

        private void BTN_MUL_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operand = "*";
        }

        private void BTN_SUB_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operand = "-";
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operand = "+";
        }

        private void EQUAL_BTN_Click(object sender, EventArgs e)
        {
            num2= Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            switch (operand)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            richTextBox1.Text = result.ToString();
            num1 = 0;
            num2 = 0;
            operand = "";
            result = 0;
        }
    }
}
