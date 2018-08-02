using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;



/// <summary>
/// Summary description for Conexao
/// </summary>
public class Conexao
{
	string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Desktop\versoes antigas\Trabalho\App_Data\laboratorio.mdf;Integrated Security = True";
    SqlConnection conexao = new SqlConnection();
	public Conexao()
	{

		
	}

    public SqlConnection Conectar()
    {
        conexao.ConnectionString = connectionString;
        conexao.Open();
        return conexao;
    }

    public void Desconectar()
    {
        conexao.Close();
    }
}