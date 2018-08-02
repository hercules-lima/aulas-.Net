using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        double numero = Convert.ToDouble(Request.QueryString["numero"].ToString());//variavel que recebe o numero da querystring
        string tipo = Request.QueryString["tipo"].ToString();//recebe o tipo da querystring
        if(tipo=="dolar")//verifica se o tipo é dolar e faz o calculo convertendo o numero 
        {
            numero=numero* 3.11;
            Label1.Text ="Convertido em dolar="+ numero.ToString(); //mostra na tela
        }
        else if (tipo == "euro")//verifica se o tipo é euro e faz o calculo convertendo o numero 
        {
            numero = numero * 3.29;
            Label1.Text = "Convertido em euro=" + numero.ToString();//mostra na tela
        }
    }
}