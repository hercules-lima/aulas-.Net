using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Page.PreviousPage != null)//enviando por propriedade
        //{
        //    Label1.Text = PreviousPage.Nome;
        //}
        if (Page.PreviousPage != null)//VERIFICA A PAGINA ANTERIOR
        {
            //cria um textbox idetico ao da pagina anterior
            TextBox OrigemTextBox = (TextBox)Page.PreviousPage.FindControl("TextBox1");
            //se existir 
            if (OrigemTextBox != null)
            {
                Label1.Text = OrigemTextBox.Text;
            }
        }
    }
}