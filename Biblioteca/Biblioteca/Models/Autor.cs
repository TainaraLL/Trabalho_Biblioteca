namespace Biblioteca.Models
{
    public class Autor
    {
        public int Id_Autor { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public DateOnly DataNasc { get; set; }
    }
}