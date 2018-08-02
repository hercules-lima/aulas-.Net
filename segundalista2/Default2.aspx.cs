using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public string[,] vaga;//matriz de lugares
    protected void Page_Load(object sender, EventArgs e)
    {
        vaga = new string[10, 10];//a matriz é alocada com 10 fileiras e 10 poltronas em cada
        if (Page.PreviousPage != null)//se a previouspage que nesse caso é a default for diferente de null executa
        {
            string nome = PreviousPage.nome;//propriedade nome
            int fileira = PreviousPage.fileira;//a fileira
            int poltrona = PreviousPage.poltrona;//a poltrona
            if (vaga[fileira, poltrona] == null)//se o lugar que o usuario pediu na primeira pagina tiver vago
            {
               
                vaga[fileira, poltrona] = nome;//o nome dele é colocado naquela posição
           
            }
            else Response.Write("Esse lugar ja esta ocupado!");
        }
        Response.Write("Mapa de lugares!!<br>");
        for (int i = 0; i<10; i++)//repetição que mostra os lugares na tela
        {
            for (int j = 0; j<10; j++)
            {
                if (vaga[i, j] == null)
                    Response.Write(" Livre ");
               else
                    Response.Write(" "+vaga[i, j]+" ");
                
            }
            Response.Write("<br>");

        }
      
    }
}