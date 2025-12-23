using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork.LabWork
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text= "CurrentDate: "+Calendar1.SelectedDate.ToString();
        }

        protected void Calendar2_SelectionChanged1(object sender, EventArgs e)
        {
            Label2.Text = "DOB= "+ Calendar2.SelectedDate.ToString();

        }
    }
}