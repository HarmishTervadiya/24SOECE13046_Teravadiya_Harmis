using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork.LabWork
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HiddenField2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        protected void ButtonViewState_Click(object sender, EventArgs e)
        {
            ViewState["bane"] = TextBox1.Text;
            LabelViewState.Text = "Value saved in ViewState";
        }

        protected void ButtonHidden_Click(object sender, EventArgs e)
        {
            HiddenField2.Value = "HiddenFieldValue is here";
            LabelHidden.Text = "Hidden Field Value: " + HiddenField2.Value;

        }

        protected void ButtonCreateCookie_Click(object sender, EventArgs e)
        {
            Response.Cookies["create"].Value = TextBox2.Text;
            Response.Cookies["create"].Expires = DateTime.Now.AddMinutes(1);
            LabelCookie.Text = "Cookie Created";
        }

        protected void ButtonReadCookie_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["create"] != null)
            {

            LabelCookie.Text = "Read Cookie: " + Request.Cookies["create"].Value;
            }
            else
            {
                LabelCookie.Text = "Expired";
            }

        }

        protected void Buttonquery_Click(object sender, EventArgs e)
        {

        }
    }
}