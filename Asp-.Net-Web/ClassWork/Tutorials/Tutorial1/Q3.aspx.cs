using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork.Tutorials.Tutorial1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonCalc_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (!double.TryParse(TextBoxA.Text, out a) || !double.TryParse(TextBoxB.Text, out b))
            {
                LabelResult.Text = "Invalid input";
                return;
            }
            switch (DropDownOp.SelectedValue)
            {
                case "+":
                    LabelResult.Text = (a + b).ToString();
                    break;
                case "-":
                    LabelResult.Text = (a - b).ToString();
                    break;
                case "*":
                    LabelResult.Text = (a * b).ToString();
                    break;
                case "/":
                    if (b == 0)
                    {
                        LabelResult.Text = "Invalid input";
                        break;
                    }
                    LabelResult.Text = (a / b).ToString();
                    break;
                default:
                    LabelResult.Text = "Invalid input";
                    break;
            }
        }
    }
}