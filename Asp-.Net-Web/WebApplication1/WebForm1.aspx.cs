using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int no1=Convert.ToInt32(TextBox2.Text);
            int no2=Convert.ToInt32(TextBox1.Text);

            Label3.Text = "Result: "+ (no1+no2);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           TextBox2.Text="";
           TextBox1.Text="";

            Label3.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(TextBox2.Text);
            int no2 = Convert.ToInt32(TextBox1.Text);

            Label3.Text = "Result: " + (no1 * no2);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(TextBox2.Text);
            int no2 = Convert.ToInt32(TextBox1.Text);

            Label3.Text = "Result: " + (no1 / no2);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(TextBox2.Text);
            int no2 = Convert.ToInt32(TextBox1.Text);

            Label3.Text = "Result: " + (no1 - no2);
        }
    }
}