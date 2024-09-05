using MySql.Data.MySqlClient;
public static class Conexao
{
    static MySqlConnection conexao; 
    public static MySqlConnection Conectar()
    {
		try
		{
			string strconexao = "server=localhost;port=3360;  uid=root; pwd= root; database= db_carros";
			conexao = new MySqlConnection(strconexao);
			conexao.Open();
            Console.WriteLine("Conexão realizada com sucesso!");
        }
		catch (Exception ex)
		{
			throw new Exception("Erro ao Conectar " +  ex.Message);
           
        }
		  return conexao;
	}

	public static void FecharConexao()
	{
		conexao.Close();
	}

	
}