namespace Biblioteca.Models
{
    public class Funcionario
    {
        public int Id_Funcionario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public Endereco endereco;
        public Cargo cargo;
    }
}