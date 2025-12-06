namespace Biblioteca.Models
{
    public class Exemplar
    {
        public int Id_Exempla {get; set;}
        public int Quant { get; set; }
        public string Estado_Fisico { get; set; }

        public Livro livro;
        public Editora editora;
    }
}