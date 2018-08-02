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
        Response.Write(Response.Cookies["hora"].Value);

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
     
        ViewState["nome"] = TextBox2.Text;
        ViewState["Telefone"] = TextBox3.Text;
        ViewState["email"] = TextBox2.Text;
        Label4.Text = ViewState["nome"].ToString();
        Label5.Text = ViewState["Telefone"].ToString();
        Label6.Text = ViewState["email"].ToString();



    }
}
