using MySql.Data.MySqlClient;
using Biblioteca.Utilitarios;
using Biblioteca.Models;
using Biblioteca.Interface;

namespace Biblioteca.DAO
{
    internal class EnderecoDAO : IDao<Endereco>
    {
        public void Create(Endereco endereco)
        {
            try
            {
                string sql = @"INSERT INTO endereco (estado, cidade, bairro, rua, num_casa)
                               VALUES (@estado, @cidade, @bairro, @rua, @num_casa)";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@num_casa", endereco.NumCasa);

                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Endereco endereco)
        {
            try
            {
                string sql = @"UPDATE endereco SET estado = @estado, cidade = @cidade, bairro = @bairro, rua = @rua, num_casa = @num_casa
                               WHERE id_endereco = @id_endereco";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@num_casa", endereco.NumCasa);
                    cmd.Parameters.AddWithValue("@id_endereco", endereco.Id_Endereco);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum endereço foi atualizado (ID não existe).");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id_endereco)
        {
            try
            {
                string sql = @"DELETE FROM endereco WHERE id_endereco = @id_endereco";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_endereco", id_endereco);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum endereço encontrado com esse ID.");
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Endereco> GetAll()
        {
            List<Endereco> listEnd = new List<Endereco>();

            try
            {
                string sql = @"SELECT * FROM endereco ORDER BY cidade";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Endereco end = new Endereco();

                        end.Id_Endereco = dr.GetInt32("id_endereco");
                        end.Estado = dr.GetString("estado");
                        end.Cidade = dr.GetString("cidade");
                        end.Bairro = dr.GetString("bairro");
                        end.Rua = dr.GetString("rua");
                        end.NumCasa = dr.GetInt32("num_casa");

                        listEnd.Add(end);
                    }
                }

                return listEnd;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
