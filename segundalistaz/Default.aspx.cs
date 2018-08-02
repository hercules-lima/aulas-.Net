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

    protected void Button1_Click(object sender, EventArgs e)//Quando a pessoa clica no botao
    {
       double numero = Convert.ToDouble(TextBox1.Text);//uma variavel recebe o numero que vai ser convertido
        string tipo="";//variavel criada para receber o tipo de converção de um radiobutton
        if(RadioButton1.Checked)//radiobutton do dolar
        {
            tipo = RadioButton1.Text;

        }
        if(RadioButton2.Checked)//radiobutton do euro
        {
            tipo = RadioButton2.Text;

        }
        Response.Redirect("Default2.aspx?numero=" + numero + "&tipo=" + tipo);//manda uma querystring para default2 com o numero e o tipo de converçao

    }
}