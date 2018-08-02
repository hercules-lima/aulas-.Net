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
        Response.Cookies["hora"].Value = DateTime.Now.ToString();
        Response.Cookies["hora"].Expires = DateTime.Now.AddDays(1d);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");

    }
}