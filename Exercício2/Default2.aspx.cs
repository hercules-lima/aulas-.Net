using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public int[,] Matriz3//matriz de lugares
    {
        get;
        set;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int[,] Aux;
        Aux = (int[,])Session["Matriz"];
        Matriz3 = Aux;

        Response.Write("Mapa de Lugares!!<br>");

        for (int i = 0; i < 10; i++)//repetição que mostra os lugares na tela
        {
            for (int j = 0; j < 10; j++)
            {
                if (Matriz3[i, j] == 0)
                    Response.Write("  Disponivel  ");
                else
                    Response.Write("  Reservado   ");

            }
            Response.Write("<br><br>");

        }

    }

}