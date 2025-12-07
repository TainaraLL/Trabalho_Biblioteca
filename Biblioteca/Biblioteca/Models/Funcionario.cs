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
        public Cargo cargo;namespace Biblioteca.Models
    {
        public class Funcionario
        {
            public int Id_Funcionario { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }

            public string Cpf;
            public string Email { get; set; }

            public int Id_Endereco;
            public int Id_Cargo;

            public Funcionario()
            {

            }

            public Funcionario(string _cpf)
            {
                Cpf = _cpf;

                SetCpf(_cpf);
            }

            public void SetCpf(string _cpf)
            {
                _cpf = _cpf.Replace(".", "").Replace("-", "");

                //primeiro digito verificador

                int soma1 = 0;
                int multiplicar1 = 10;
                int resto;
                int digito;

                if (_cpf.Length != 11)
                {
                    throw new Exception("CPF tem que ter 11 digitos");
                }

                for (int i = 0; i < 9; i++)
                {
                    soma1 += int.Parse(_cpf[i].ToString()) * multiplicar1;
                    multiplicar1--;
                }

                resto = soma1 % 11; //calcular o resto da divisão

                if (resto < 2)
                {
                    digito = 0;
                }

                else
                {
                    digito = 11 - resto;
                }

                if (digito != int.Parse(_cpf[9].ToString()))
                    throw new Exception("Primeiro digito está incorreto!");

                //segundo digito verificador

                int soma2 = 0;
                int multiplicar2 = 11;
                int resto2;
                int digito2;

                for (int i = 0; i < 10; i++)
                {

                    soma2 += int.Parse(_cpf[i].ToString()) * multiplicar2;
                    multiplicar2--;
                }
                resto2 = soma2 % 11; //calcular o resto da divisão

                if (resto2 < 2)
                {
                    digito2 = 0;
                }

                else
                {
                    digito2 = 11 - resto2;
                }

                if (digito2 != int.Parse(_cpf[10].ToString()))
                    throw new Exception("Segundo digito está incorreto!");
            }

            public string GetCpf()
            {
                return Cpf;
            }
        }
    }
}
}