namespace Biblioteca.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public int Id_Endereco_Fk { get; set; }

        public Endereco _Endereco { get; set; }

        public Usuario()
        {

        }

        public Usuario(string _cpf)
        {
            Cpf = _cpf;

            SetCpf(_cpf);
        }

        public void SetCpf(string _cpf)
        {
            _cpf = _cpf.Replace(".", "").Replace("-", "");

            if (_cpf.Length != 11)
            {
                throw new Exception("CPF Inválido");
            }

            // Validar 1° Didito
            int contador = 10;
            int somaMult = 0;

            for (int i = 0; i < _cpf.Length - 2; i++)
            {
                somaMult += int.Parse(_cpf[i].ToString()) * contador; //Converte de string para int.
                contador--;
            }

            int mod = somaMult % 11; //calcular o resto da divisão. mod = resto

            if (mod < 2 && int.Parse(_cpf[9].ToString()) != 0) //SE mod for menor que 2 E o digito é 0
            {
                throw new Exception("CPF Inválido");
            }

            else if (mod >= 2)
            {
                int digitoVali = 11 - mod;

                if (int.Parse(_cpf[9].ToString()) != digitoVali) //SE
                {
                    throw new Exception("CPF Inválido");
                }
            }

            // Validar 2 ° Didito
            contador = 11;
            somaMult = 0;

            for (int i = 0; i < _cpf.Length - 1; i++)
            {
                somaMult += int.Parse(_cpf[i].ToString()) * contador; //Converte de string para int.
                contador--;
            }

            mod = somaMult % 11; //calcular o resto da divisão. mod = resto

            if (mod < 2 && int.Parse(_cpf[10].ToString()) != 0)
            {
                throw new Exception("CPF Inválido");
            }

            else if (mod >= 2)
            {
                int digitoVali = 11 - mod;
                if (int.Parse(_cpf[10].ToString()) != digitoVali) //SE
                {
                    throw new Exception("CPF Inválido");
                }
            }
        }

        public string GetCpf()
        {
            return Cpf;
        }
    }
}