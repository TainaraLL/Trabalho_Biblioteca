using Biblioteca.Models;

List<Categoria> listCategoria = new List<Categoria>();
//List<Cargo> listCargo = new List<Cargo>();
//List<Status> listStatus = new List<Status>();
//List<Autor> listAutor = new List<Autor>();
//List<Endereco> listEndereco = new List<Endereco>();
//List<Usuario> listUsuario = new List<Usuario>();
//List<Funcionario> listFunc = new List<Funcionario>();
//List<Editora> listEditora = new List<Editora>();
//List<Livro> listLivro = new List<Livro>();
//List<Exemplar> listExemplar = new List<Exemplar>();
//List<Emprestimo> listEmprestimo = new List<Emprestimo>();

try
{
    int opc;

    do
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("                                     MENU                                          ");
        Console.WriteLine("-----------------------------------------------------------------------------------\n");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("0- Sair");

        Console.WriteLine("----------- CADASTROS -----------\n");
        Console.WriteLine("1- Cadastrar Categoria");
        Console.WriteLine("2- Cadastrar Cargo");
        Console.WriteLine("3- Cadastrar Status");
        Console.WriteLine("4- Cadastrar Autor");
        Console.WriteLine("5- Cadastrar Endereço");
        Console.WriteLine("6- Cadastrar Usuário");
        Console.WriteLine("7- Cadastrar Funcionário");
        Console.WriteLine("8- Cadastrar Editora");
        Console.WriteLine("9- Cadastrar Livro");
        Console.WriteLine("10- Cadastrar Exemplar");
        Console.WriteLine("11- Cadastrar Emprestimo");
        Console.WriteLine("12- Cadastrar Autor_Livro");

        Console.WriteLine("----------- CONSULTAS -----------\n");
        Console.WriteLine("13- Consultar Categoria");
        Console.WriteLine("14- Consultar Cargo");
        Console.WriteLine("15- Consultar Status");
        Console.WriteLine("16- Consultar Autor");
        Console.WriteLine("17- Consultar Endereço");
        Console.WriteLine("18- Consultar Usuário");
        Console.WriteLine("19- Consultar Funcionário");
        Console.WriteLine("20- Consultar Editora");
        Console.WriteLine("21- Consultar Livro");
        Console.WriteLine("22- Consultar Exemplar");
        Console.WriteLine("23- Consultar Emprestimo");
        Console.WriteLine("24- Consultar Autor_Livro");

        Console.Write("\nEscolha uma das opções: ");
        opc = Convert.ToInt16(Console.ReadLine());

        switch (opc)
        {
            // TELAS DE CADASTROS
            //case 1: CadCategoria();
            //    break;

            //case 2: CadCargo();
            //    break;

            //case 3: CadStatus();
            //    break;

            //case 4: CadAutor();
            //    break;

            //case 5: CadEndereco();
            //    break;

            //case 6: CadUsuario();
            //    break;

            //case 7: CadFuncionario();
            //    break;

            //case 8: CadEditora();
            //    break;

            //case 9: CadLivro();
            //    break;

            //case 10: CadExemplar();
            //    break;

            //case 11: CadEmprestimo();
            //    break;

            //case 12: CadAutorLivro();
            //    break;


            // TELAS DE CONSULTAS 
            //case 13:
            //    CadCategoria();
            //    break;

            //case 14:
            //    CadCargo();
            //    break;

            //case 15:
            //    CadStatus();
            //    break;

            //case 16:
            //    CadAutor();
            //    break;

            //case 17:
            //    CadEndereco();
            //    break;

            //case 18:
            //    CadUsuario();
            //    break;

            //case 19:
            //    CadFuncionario();
            //    break;

            //case 20:
            //    CadEditora();
            //    break;

            //case 21:
            //    CadLivro();
            //    break;

            //case 22:
            //    CadExemplar();
            //    break;

            //case 23:
            //    CadEmprestimo();
            //    break;

            //case 24:
            //    CadAutorLivro();
            //    break;
        }

    } while (opc == 0);

    // ----------------------------------------------------------- \\


    // CADASTRAR CATEGORIA
    void CadCategoria()
    {
        Categoria objCategoria = new Categoria();

        Console.Write("Digite o nome da categoria: ");
        //objCategoria.Nome = Console.ReadLine();

        listCategoria.Add(objCategoria);

        /*Aluguel aluguelObj = new Aluguel();

        WriteLine("Selecione o Cliente: ");
        int cont = 0;
        foreach (var item in clienteList)
        {
            WriteLine($"{cont + 1} {item.nome}");
            cont++;
        }
        int cliSelecionado = int.Parse(ReadLine()) - 1;
        aluguelObj.cliente = clienteList[cliSelecionado];*/
    }

    // CONSULTAR CATEGORIA 
    void ConsCategoria()
    {
        foreach (var obj in listCategoria)
        {
            Console.Write(obj.ToString());
        }
    }



    // CADASTRAR CARGO
    void CadCargo()
    {

    }

    // CONSULTAR CARGO 
    void ConsCargo()
    {

    }



    // CADASTRAR STATUS
    void CadStatus()
    {

    }

    // CONSULTAR STATUS 
    void ConsStatus()
    {

    }



    // CADASTRAR AUTOR
    void CadAutor()
    {

    }

    // CONSULTAR AUTOR 
    void ConsAutor()
    {

    }



    // CADASTRAR ENDEREÇO
    void CadEndereco()
    {

    }

    // CONSULTAR ENDEREÇO
    void ConsEndereco()
    {

    }



    // CADASTRAR USUÁRIO
    void CadUsuario()
    {

    }

    // CONSULTAR USUÁRIO
    void ConsUsuario()
    {

    }



    // CADASTRAR FUNCIONÁRIO
    void CadFuncionario()
    {

    }

    // CONSULTAR FUNCIONÁRIO
    void ConsFuncionario()
    {

    }



    // CADASTRAR EDITORA
    void CadEditora()
    {

    }

    // CONSULTAR EDITORA
    void ConsEditora()
    {

    }



    // CADASTRAR LIVRO
    void CadLivro()
    {
        
    }

    // CONSULTAR LIVRO
    void ConsLivro()
    {

    }



    // CADASTRAR EXEMPLAR
    void CadExemplar()
    {

    }

    // CONSULTAR EXEMPLAR
    void ConsExemplar()
    {

    }



    // CADASTRAR EMPRÉSTIMO
    void CadEmprestimo()
    {

    }

    // CONSULTAR EMPRÉSTIMO
    void ConsEmprestimo()
    {

    }



    // CADASTRAR AUTOR_LIVRO
    void CadAutorLivro()
    {

    }

    // CONSULTAR AUTOR_LIVRO
    void ConsAutorLivro()
    {

    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}