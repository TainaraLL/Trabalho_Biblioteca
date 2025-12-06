namespace Biblioteca.Models
{
    public class Endereco
    {
        public int Id_Endereco { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }

        public int NumCasa { get; set; }
    }
}