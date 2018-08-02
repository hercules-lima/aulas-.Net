using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for manutencao
/// </summary>
public class manutencao
{
	public manutencao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void inserir(int cod, int codequip,DateTime data,int estado,string obser)
    {
        Conexao c = new Conexao();
        string sql = "INSERT INTO Manutenção VALUES(" + cod + "," + codequip + ",'"+data+"',"+estado+",'"+obser+"')";
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        comando.ExecuteNonQuery();
        c.Desconectar();


    }
    public void atualizar(int cod, int codequip,DateTime data,int estado,string obser)
    {
        Conexao c = new Conexao();
        string sql = "UPDATE   Manutenção SET Equipamento=" + codequip+ ", Data='" + data+ "',Estado=" + estado+ ",Observação='" + obser+ "' WHERE Cod_Manutencao="+cod ;
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        comando.ExecuteNonQuery();
        c.Desconectar();
    }
    public void delete(int cod)
    {
        Conexao c = new Conexao();
        string sql = "DELETE FROM Manutenção WHERE Cod_Manutencao=" + cod;
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        comando.ExecuteNonQuery();
        c.Desconectar();
    }
    public SqlDataReader selectman(int codigo )
    {
        Conexao c = new Conexao();
        string sql = "SELECT * FROM Manutenção WHERE Cod_Manutencao=" + codigo;
        SqlConnection conn = c.Conectar();
        SqlCommand comando = new SqlCommand(sql, conn);
        SqlDataReader reader = comando.ExecuteReader();
        return reader;

    }


}