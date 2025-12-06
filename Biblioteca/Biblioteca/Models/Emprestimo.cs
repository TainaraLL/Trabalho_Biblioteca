namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id_Emprestimo { get; set; }

        public DateOnly Data_Emprestimo { get; set; }
        public DateOnly DataPrevi_Devolucao { get; set; }
        public DateOnly Data_Devolucao { get; set; }
        public string Obervacao { get; set; }

        public Funcionario funcionario;
        public Usuario usuario;
        public Exemplar exemplar;
    }
}
