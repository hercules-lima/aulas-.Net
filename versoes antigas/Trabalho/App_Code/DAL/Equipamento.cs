using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Equipamento
/// </summary>
public class Equipamento
{
	public Equipamento()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void inserir(int cod, string nome)
    {
        Conexao c = new Conexao();
        string sql="INSERT INTO Equipamentos(Codigo,Nome) VALUES("+cod+",'"+nome+"')";
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        comando.ExecuteNonQuery();





    }
    public void atualizar(int cod,string nome)
    {
        Conexao c = new Conexao();
        string sql = "UPDATE Equipamentos  SET Nome='"+nome+"' WHERE Codigo="+cod;
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        comando.ExecuteNonQuery();
        c.Desconectar();
    }
    public void deleteequipa(int cod)
    {
      
            Conexao c = new Conexao();
            string sql = "DELETE FROM Equipamentos WHERE Codigo=" + cod;
            SqlConnection conn = c.Conectar();
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.ExecuteNonQuery();
            c.Desconectar();

 
     
    }
    public SqlDataReader selectman(int codigo)
    {
        Conexao c = new Conexao();
        string sql = "SELECT * FROM Equipamentos WHERE Codigo="+codigo;
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        SqlDataReader reader = comando.ExecuteReader();
        return reader;

    }

}