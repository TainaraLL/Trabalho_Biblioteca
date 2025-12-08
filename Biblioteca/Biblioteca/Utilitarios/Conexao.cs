using MySql.Data.MySqlClient;

namespace Biblioteca.Utilitarios
{
    internal class Conexao
    {
        /* Contante com os dados de conexão, como senha e banco de dados  
           Constantes são valores imutáveis, define na compilção e não muda durante a execução */
        private const string strConexao = "server=localhost;port=3306;uid=root;pwd=root;database=biblioteca_leal"; //CONST é uma "variável" que não muda.

        public static MySqlConnection Conectar()
        {
            // Cria um novo objeto de conexão usando a string de conexão definida
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                // Tenta abrir a conexão com o banco de dados
                conexao.Open();

                return conexao;
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro ao conectar, lança a exceção
                throw new Exception(strConexao, ex);
            }
        }
    }

}