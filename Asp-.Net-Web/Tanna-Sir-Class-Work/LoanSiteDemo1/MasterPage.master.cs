using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        Label1.Text = "Logged In: " + Session["user"].ToString();
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("Login.aspx");
    }

    protected void Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void New_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewApplication.aspx");

    }

    protected void Update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateApplication.aspx");

    }

    protected void Remove_Click(object sender, EventArgs e)
    {
        Response.Redirect("DiscardApplication.aspx");

    }

    protected void View_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAll.aspx");

    }
}
