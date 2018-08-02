using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string Nome
    {
        get { return TextBox1.Text; }
    }
    public int Fileira
    {
        get { return int.Parse(TextBox2.Text); }

    }
    public int Poltrona
    {
        get { return int.Parse(TextBox3.Text); }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int[,] Aux;
        Aux = (int[,])Application["Matriz"];
        if (Aux[Fileira - 1, Poltrona - 1] != 1)
        {
            Aux[Fileira - 1, Poltrona - 1] = 1;
            Label4.Text = "Status: Rezervado com sucesso!";
        }
        else
        {
            Label3.Text = "Ja Rezervado";
        }

        Session["Matriz"] = Aux;
        Server.Transfer("default2.aspx");
    }

}