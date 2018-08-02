using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //propriedades de leitura
    public string nome//propriedade  que recebe do textbox o nome
    {
        get
        {
            return TextBox1.Text;
        }
    }
    public int fileira//recebe o numero de fileiras
    {
        get
        {
            return Convert.ToInt32(TextBox2.Text)-1;
        }
    }
    public int poltrona//recebe nomeero de poltronas
    {
        get
        {
            return Convert.ToInt32(TextBox3.Text)-1;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
   

    }
}