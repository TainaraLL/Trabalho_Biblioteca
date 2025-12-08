using MySql.Data.MySqlClient;
using Biblioteca.Utilitarios;
using Biblioteca.Models;
using Biblioteca.Interface;
using System.ComponentModel;

namespace Biblioteca.DAO
{
    internal class UsuarioDAO : IDao<Usuario> // métodos de acesso ao banco de dados
    {
        public void Create(Usuario usuario)
        {
            try
            {
                string sql = @"INSERT INTO usuario (telefone, cpf, email, nome, id_endereco_fk)
                               VALUES (@telefone, @cpf, @email, @nome, @id_endereco_fk)";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@id_endereco_fk", usuario.Id_Endereco_Fk);

                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                string sql = @"UPDATE usuario SET telefone = @telefone, cpf = @cpf, email = @email, nome = @nome, id_endereco_fk = @id_endereco_fk
                               WHERE id_usuario = @id_usuario;";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@id_endereco_fk", usuario.Id_Endereco_Fk);
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_Usuario);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum registro foi atualizado (ID inexistente).");
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id_usuario)
        {
            try
            {
                string sql = @"DELETE FROM usuario WHERE id_usuario = @id_usuario";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0)
                    {
                        throw new Exception("Nenhum registro encontrado com esse ID.");
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> listUser = new List<Usuario>();

            try
            {
                string sql = @"SELECT u.*, e.estado, e.cidade, e.bairro, e.rua, e.num_casa, e.id_endereco FROM usuario AS u 
                    INNER JOIN endereco AS e ON u.id_endereco_fk = e.id_endereco ORDER BY u.id_usuario";

                using (var conexao = Conexao.Conectar())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Usuario objUser = new Usuario();

                        objUser.Id_Usuario = dr.GetInt32("id_usuario");
                        objUser.Telefone = dr.GetString("telefone");
                        objUser.Cpf = dr.GetString("cpf");
                        objUser.Email = dr.GetString("email");
                        objUser.Nome = dr.GetString("nome");
                        objUser.Id_Endereco_Fk = dr.GetInt32("id_endereco_fk");

                        objUser._Endereco = new Endereco()
                        {
                            Id_Endereco = dr.GetInt32("id_endereco"),
                            Estado = dr.GetString("estado"), 
                            Cidade = dr.GetString("cidade"),
                            Bairro = dr.GetString("bairro"),
                            Rua = dr.GetString("rua"),
                            NumCasa = dr.GetInt32("num_casa")
                        };

                        listUser.Add(objUser);
                    }
                }

                return listUser;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}