namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id_Livro { get; set; }
        public string Titulo { get; set; }
        public int AnoPubli { get; set; }
        public int Edicao { get; set; }
        public string Sinopse { get; set; }
        public string Descricao { get; set; }
        public string Isbn { get; set; }

        // FK CATEGORIA
        // FK EDITORA 
    }
}