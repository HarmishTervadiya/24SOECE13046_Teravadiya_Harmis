using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork.Tutorials.Tutorial1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonConvert_Click(object sender, EventArgs e)
        {
            double v;
            if (!double.TryParse(TextBoxTemp.Text, out v))
            {
                LabelConverted.Text = "Invalid input";
                return;
            }
            if (DropDownConversion.SelectedValue == "CtoF")
            {
                double f = v * 9.0 / 5.0 + 32.0;
                LabelConverted.Text = f.ToString();
                return;
            }
            double c = (v - 32.0) * 5.0 / 9.0;
            LabelConverted.Text = c.ToString();
        }
    }
}