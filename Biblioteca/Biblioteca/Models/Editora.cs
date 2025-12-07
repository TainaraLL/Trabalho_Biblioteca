namespace Biblioteca.Models
{
    public class Editora
    {
        public int Id_Editora { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }

        public int Id_Endereco;
    }
}