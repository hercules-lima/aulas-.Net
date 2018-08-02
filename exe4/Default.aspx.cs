using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text=="teste" && TextBox2.Text=="123")
        {
            Session["status"] = "logado";
            Response.Redirect("Default2.aspx");


        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}