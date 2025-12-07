namespace Biblioteca.Models
{
    public class Exemplar
    {
        public int Id_Exemplar {get; set;}
        public int Quant { get; set; }
        public string Estado_Fisico { get; set; }

        public int Id_Livro;
        public int Id_Status;
    }
}