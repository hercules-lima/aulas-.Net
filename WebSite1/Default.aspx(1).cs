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
        Response.Write(Application["contador"]);
        Response.Cookies["nome"].Value = "celso";
        Response.Cookies["nome"].Expires = DateTime.Now.AddDays(1d);
        ViewState["sobrenome"] = "avila";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Response.Cookies["nome"].Value!=null)
            Response.Write(" "+Response.Cookies["nome"].Value);
        if (ViewState["sobrenome"] != null)
            Response.Write(" "+ViewState["sobrenome"]);

    }
}