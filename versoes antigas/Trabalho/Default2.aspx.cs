using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LabelERRO.Text = "";
        LabelERRO2.Text = "";
        try
        {
            Equipamento F = new Equipamento();
            F.inserir(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
        }
        catch (SqlException )
        {

            LabelERRO.Text = "Erro:Codigo do equipamento pode estar duplicado, Pode ter campos sem preencher ou de tipos incorretos!!  ";
        }
        catch (Exception n)
        {

            LabelERRO.Text = n.Message;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        LabelERRO.Text = "";
        LabelERRO2.Text = "";
        try
        {
            Equipamento F = new Equipamento();
            F.atualizar(Convert.ToInt32(TextBox1.Text), TextBox2.Text);

        }
        catch (SqlException )
        {

            LabelERRO.Text = "Erro:Pode ter campos sem preencher ou de tipos incorretos!! ";
        }
        catch (Exception n)
        {

            LabelERRO.Text=n.Message;
        }
     


    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        LabelERRO.Text = "";
        LabelERRO2.Text = "";
        try
        {
            Equipamento F = new Equipamento();
            F.deleteequipa(Convert.ToInt32(TextBox1.Text));
        }
        catch (SqlException )
        {

            LabelERRO.Text = "Erro:Este equipamento pode estar em manutenção!!  ";
        }
        catch (Exception n)
        {

            LabelERRO.Text = n.Message;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        LabelERRO.Text = "";
        LabelERRO2.Text = "";
        try
        {
            Equipamento F = new Equipamento();
            SqlDataReader read = F.selectman(Convert.ToInt32(TextBox1.Text));
            if (!read.HasRows)
            {
                LabelERRO.Text = "Codigo Ineistente!!";
            }
            if (read.Read())
            {
                TextBox2.Text = read.GetString(1).ToString();
            }

        }
        catch (SqlException )
        {

            LabelERRO.Text = "Erro:Pode ter campos sem preencher ou de tipos incorretos!! ";
        }
        catch (Exception n)
        {

            LabelERRO.Text = n.Message;
        }

    }

    protected void Button5_Click(object sender, EventArgs e)
    {

    }

    protected void Button5_Click1(object sender, EventArgs e)
    {
        LabelERRO2.Text = "";
        LabelERRO.Text = "";
        try
        {

            manutencao F = new manutencao();
            F.inserir(Convert.ToInt32(TextBox7.Text), Convert.ToInt32(TextBox8.Text), Convert.ToDateTime(TextBox9.Text), Convert.ToInt32(TextBox10.Text), TextBox11.Text);

        }
        catch (SqlException )
        {

            LabelERRO2.Text = "Erro:Codigo da manutenção pode estar duplicado, Pode ter campos sem preencher ou de tipos incorretos!!   ";
        }
        catch (Exception n)
        {

            LabelERRO2.Text = n.Message;
        }

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        LabelERRO2.Text = "";
        LabelERRO.Text = "";
        try
        {
            manutencao F = new manutencao();
            F.atualizar(Convert.ToInt32(TextBox7.Text), Convert.ToInt32(TextBox8.Text), Convert.ToDateTime(TextBox9.Text), Convert.ToInt32(TextBox10.Text), TextBox11.Text);
        }
        catch (SqlException )
        {

            LabelERRO2.Text = "Erro:Pode ter campos sem preencher ou de tipos incorretos!!  ";
        }
        catch (Exception n)
        {

            LabelERRO2.Text = n.Message;
        }

    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        LabelERRO2.Text = "";
        LabelERRO.Text = "";
        try
        {
            manutencao F = new manutencao();
            F.delete(Convert.ToInt32(TextBox7.Text));

        }
        catch (SqlException )
        {

            LabelERRO2.Text = "Erro!! ";
        }
        catch (Exception n)
        {

            LabelERRO2.Text = n.Message;
        }

    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        LabelERRO2.Text = "";
        LabelERRO.Text = "";
        try
        {

            manutencao F = new manutencao();
            SqlDataReader read = F.selectman(Convert.ToInt32(TextBox7.Text));
            if(!read.HasRows)
            {
                LabelERRO2.Text = "Codigo Inexistente!!";
            }
            if (read.Read())
            {
                TextBox8.Text = read.GetInt32(1).ToString();
                TextBox9.Text = read.GetDateTime(2).ToString();
                TextBox10.Text = read.GetInt32(3).ToString();
                TextBox11.Text = read.GetString(4).ToString();
            }

        }
        catch (SqlException )
        {

            LabelERRO2.Text = "Erro:Pode ter campos sem preencher ou de tipos incorretos!! ";
        }
        catch (Exception n)
        {

            LabelERRO2.Text = n.Message;
        }
      

    }
}