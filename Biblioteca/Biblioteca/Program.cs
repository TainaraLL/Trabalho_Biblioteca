using Biblioteca.DAO;
using Biblioteca.Models;

/*List<Categoria> listCategoria = new List<Categoria>();
List<Cargo> listCargo = new List<Cargo>();
List<Status> listStatus = new List<Status>();
List<Autor> listAutor = new List<Autor>();
List<Funcionario> listFunc = new List<Funcionario>();
List<Editora> listEditora = new List<Editora>();
List<Livro> listLivro = new List<Livro>();
List<Exemplar> listExemplar = new List<Exemplar>();
List<Emprestimo> listEmprestimo = new List<Emprestimo>();
List<Autor_Livro> listAutorLivro = new List<Autor_Livro>();*/

EnderecoDAO objEndDAO = new EnderecoDAO();
UsuarioDAO objUserDAO = new UsuarioDAO();

try
{
    int opc;

    do
    {
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("                                     MENU                                          ");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("");
        Console.WriteLine("0- Sair\n");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("----------- CADASTROS -----------\n");
        Console.ResetColor();

        /*Console.WriteLine("1- Cadastrar Categoria");
        Console.WriteLine("2- Cadastrar Cargo");
        Console.WriteLine("3- Cadastrar Status");
        Console.WriteLine("4- Cadastrar Autor");
        Console.WriteLine("5- Cadastrar Endereço");*/
        Console.WriteLine("6- Cadastrar Usuário");
        Console.WriteLine("7- Cadastrar Funcionário");
        /*Console.WriteLine("8- Cadastrar Editora");
        Console.WriteLine("9- Cadastrar Livro");
        Console.WriteLine("10- Cadastrar Exemplar");
        Console.WriteLine("11- Cadastrar Emprestimo");
        Console.WriteLine("12- Cadastrar Autor_Livro");*/

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAS -----------\n");
        Console.ResetColor();

        /*Console.WriteLine("13- Consultar Categoria");
        Console.WriteLine("14- Consultar Cargo");
        Console.WriteLine("15- Consultar Status");
        Console.WriteLine("16- Consultar Autor");
        Console.WriteLine("17- Consultar Endereço");*/
        Console.WriteLine("18- Consultar Usuário");
        Console.WriteLine("19- Consultar Funcionário");
        /*Console.WriteLine("20- Consultar Editora");
        Console.WriteLine("21- Consultar Livro");
        Console.WriteLine("22- Consultar Exemplar");
        Console.WriteLine("23- Consultar Emprestimo");
        Console.WriteLine("24- Consultar Autor_Livro");*/

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- ATUALIZAÇÕES -----------\n");
        Console.ResetColor();

        Console.WriteLine("25- Atualizar Endereço");
        Console.WriteLine("26- Ataulizar Usuário");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n------------- EXCLUSÃO -------------\n");
        Console.ResetColor();

        Console.WriteLine("27- Excluir Endereço");
        Console.WriteLine("28- Excluir Usuário");

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("\nEscolha uma das opções: ");
        opc = Convert.ToInt16(Console.ReadLine());
        Console.ResetColor();

        switch (opc)
        {
            // TELAS DE CADASTROS
            /*
            case 1:
                CadCategoria();
                break;

            case 2:
                CadCargo();
                break;

            case 3:
                CadStatus();
                break;

            case 4:
                CadAutor();
                break;
            */

            case 5:
                CadEndereco();
                break;

            case 6:
                CadUsuario();
                break;

            /*
            case 7:
                CadFuncionario();
                break;

            case 8:
                CadEditora();
                break;

            case 9:
                CadLivro();
                break;

            case 10:
                CadExemplar();
                break;

            case 11:
                CadEmprestimo();
                break;

            case 12:
                CadAutorLivro();
                break;


            // TELAS DE CONSULTAS 
            case 13:
                ConsCategoria();
                break;

            case 14:
                ConsCargo();
                break;

            case 15:
                ConsStatus();
                break;

            case 16:
                ConsAutor();
                break;
            */

            case 17:
                ConsEndereco();
                break;

            case 18:
                ConsUsuario();
                break;

            /*
            case 19:
                ConsFuncionario();
                break;

            case 20:
                ConsEditora();
                break;

            case 21:
                ConsLivro();
                break;

            case 22:
                ConsExemplar();
                break;

            case 23:
                ConsEmprestimo();
                break;

            case 24:
                ConsAutorLivro();
                break;
            *
            */
            // OUTROS TELAS
            case 25:
                UpdateEndereco(objEndDAO);
                break;

            case 26:
                UpdateUsuario(objUserDAO);
                break;

            case 27:
                DeleteEndereco(objEndDAO);
                break;

            case 28:
                DeleteUsuario(objUserDAO);
                break;
        }

    } while (opc != 0);

    // ----------------------------------------------------------- \\

    /*
    // CADASTRAR CATEGORIA
    void CadCategoria()
    {
        Categoria objCategoria = new Categoria();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR CATEGORIA -----------");
        Console.ResetColor();

        Console.Write("Informe o nome da categoria: ");
        objCategoria.Nome = Console.ReadLine();

        listCategoria.Add(objCategoria);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR CATEGORIA 
    void ConsCategoria()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR CATEGORIA -----------");
        Console.ResetColor();

        foreach (var l in listCategoria)
        {
            Console.Write($"\nID: {l.Id_Categoria}");
            Console.WriteLine($"Nome: {l.Nome}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR CARGO
    void CadCargo()
    {
        Cargo obj = new Cargo();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR CARGO -----------");
        Console.ResetColor();

        Console.Write("\nDigite o nome do cargo: ");
        obj.Nome = Console.ReadLine();

        listCargo.Add(obj);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR CARGO 
    void ConsCargo()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR CARGO -----------");
        Console.ResetColor();

        foreach (var l in listCargo)
        {
            Console.WriteLine($"\nID: {l.Id_Cargo}");
            Console.WriteLine($"Nome: {l.Nome}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR STATUS
    void CadStatus()
    {
        Status s = new Status();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR STATUS -----------");
        Console.ResetColor();

        Console.Write("\nInforme o nome do status: ");
        s.Situacao = Console.ReadLine();

        listStatus.Add(s);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR STATUS 
    void ConsStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR STATUS -----------");
        Console.ResetColor();

        foreach (var s in listStatus)
        {
            Console.WriteLine($"\nID: {s.Id_Status}");
            Console.WriteLine($"Nome: {s.Situacao}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR AUTOR
    void CadAutor()
    {
        Autor a = new Autor();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR AUTOR -----------");
        Console.ResetColor();

        Console.Write("\nInforme o nome do autor: ");
        a.Nome = Console.ReadLine();

        Console.Write("Informe a nacionalidade: ");
        a.Nacionalidade = Console.ReadLine();

        listAutor.Add(a);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR AUTOR 
    void ConsAutor()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR AUTOR -----------");
        Console.ResetColor();

        foreach (var a in listAutor)
        {
            Console.WriteLine($"\nID: {a.Id_Autor}");
            Console.WriteLine($"Nome: {a.Nome}");
            Console.WriteLine($"Nacionalidade: {a.Nacionalidade}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }
    */


    // CADASTRAR ENDEREÇO
    void CadEndereco()
    {
        Endereco objEnd = new Endereco();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR ENDEREÇO -----------");
        Console.ResetColor();

        Console.Write("\nEstado: ");
        objEnd.Estado = Console.ReadLine();

        Console.Write("Cidade: ");
        objEnd.Cidade = Console.ReadLine();

        Console.Write("Bairro: ");
        objEnd.Bairro = Console.ReadLine();

        Console.Write("Rua: ");
        objEnd.Rua = Console.ReadLine();

        Console.Write("Número da casa: ");
        objEnd.NumCasa = int.Parse(Console.ReadLine());

        objEndDAO.Create(objEnd);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ReadKey();
        Console.ResetColor();
    }

    // CONSULTAR ENDEREÇO
    void ConsEndereco()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR ENDEREÇO -----------");
        Console.ResetColor();

        var listEndDAO = objEndDAO.GetAll();

        foreach (var l in listEndDAO)
        {
            Console.WriteLine($"\nID: {l.Id_Endereco}");
            Console.WriteLine($"Estado: {l.Estado}");
            Console.WriteLine($"Cidade: {l.Cidade}");
            Console.WriteLine($"Bairro: {l.Bairro}");
            Console.WriteLine($"Rua: {l.Rua}");
            Console.WriteLine($"Nº: {l.NumCasa}");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ReadKey();
            Console.ResetColor();
        }
    }

    // ATUALIZAR ENDEREÇO
    void UpdateEndereco(EnderecoDAO endDao)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- ATUALIZAR ENDEREÇO -----------");
        Console.ResetColor();

        Console.Write("\nDigite o ID do endereço que deseja atualizar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Endereco objEnd = new Endereco {Id_Endereco = id};

        Console.Write("\nEstado: ");
        objEnd.Estado = Console.ReadLine();

        Console.Write("Cidade: ");
        objEnd.Cidade = Console.ReadLine();

        Console.Write("Bairro: ");
        objEnd.Bairro = Console.ReadLine();

        Console.Write("Rua: ");
        objEnd.Rua = Console.ReadLine();

        Console.Write("Número da casa: ");
        objEnd.NumCasa = int.Parse(Console.ReadLine());

        endDao.Update(objEnd);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ReadKey();
        Console.ResetColor();
    }

    // DELETAR ENDEREÇO
    void DeleteEndereco(EnderecoDAO endDao)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\n----------- DELETAR ENDEREÇO -----------");
            Console.ResetColor();

            Console.Write("\nDigite o ID do endereço que deseja excluir: ");
            int id = Convert.ToInt32(Console.ReadLine());

            endDao.Delete(id);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ReadKey();
            Console.ResetColor();
        }

        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($"\nErro ao excluir endereço: {ex.Message}");
            Console.ResetColor();
        }
    }



    // CADASTRAR USUÁRIO
    void CadUsuario()
    {
        //var listUserDAO = objUserDAO.GetAll();

        Usuario objUser = new Usuario();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR USUÁRIO -----------");
        Console.ResetColor();

        Console.Write("\nInforme o nome do usuário: ");
        objUser.Nome = Console.ReadLine();

        Console.Write("Informe o telefone: ");
        objUser.Telefone = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        objUser.Cpf = Console.ReadLine();

        Console.Write("Informe o email: ");
        objUser.Email = Console.ReadLine();

        var list = objEndDAO.GetAll();

        Console.WriteLine("\nSelecione o endereço: ");
        
        foreach (var end in list)
        {
            Console.WriteLine($"\n{end.Id_Endereco} - {end.Estado}, {end.Cidade}, {end.Bairro} - {end.Rua}, - {end.NumCasa}");
        }

        Console.WriteLine("");

        int enderecoSelecionado = Convert.ToInt32(Console.ReadLine());
        objUser.Id_Endereco_Fk = enderecoSelecionado;

        objUserDAO.Create(objUser);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ReadKey();  
        Console.ResetColor();
    }

    // CONSULTAR USUÁRIO
    void ConsUsuario()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR USUÁRIO -----------");
        Console.ResetColor();

        var list = objUserDAO.GetAll();

        foreach (var l in list)
        {
            Console.WriteLine($"\nID: {l.Id_Usuario}");
            Console.WriteLine($"Nome: {l.Nome}");
            Console.WriteLine($"Telefone: {l.Telefone}");
            Console.WriteLine($"Email: {l.Email}");
            Console.WriteLine($"CPF: {l.Cpf}\n");

            Console.WriteLine("ENDEREÇO ----------------------------------");
            Console.WriteLine($"\nEstado: {l._Endereco.Id_Endereco}");
            Console.WriteLine($"Estado: {l._Endereco.Estado}");
            Console.WriteLine($"Cidade: {l._Endereco.Cidade}");
            Console.WriteLine($"Bairro: {l._Endereco.Bairro}");
            Console.WriteLine($"Rua: {l._Endereco.Rua}");
            Console.WriteLine($"Nº:{l._Endereco.NumCasa}");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ReadKey();
            Console.ResetColor();
        }
    }

    // ATUALIZAR USUÁRIO 
    void UpdateUsuario(UsuarioDAO userDao)
    {
        var listEndDAO = objEndDAO.GetAll();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- ATUALIZAR USUÁRIO -----------");
        Console.ResetColor();

        Console.Write("\nDigite o ID do usuário que deseja atualizar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Usuario objUser = new Usuario { Id_Usuario = id };

        Console.Write("\nInforme o nome do usuário: ");
        objUser.Nome = Console.ReadLine();

        Console.Write("Informe o telefone: ");
        objUser.Telefone = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        objUser.Cpf = Console.ReadLine();

        Console.Write("Informe o email: ");
        objUser.Email = Console.ReadLine();

        Console.WriteLine("\nSelecione o endereço: ");
        int cont = 0;

        foreach (var end in listEndDAO)
        {
            Console.WriteLine($"\n{cont + 1} - {end.Estado}, {end.Cidade}, {end.Bairro} - {end.Rua}, - {end.NumCasa}");
            cont++;
        }

        Console.WriteLine("");

        int enderecoSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;
        objUser.Id_Endereco_Fk = listEndDAO[enderecoSelecionado].Id_Endereco;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        userDao.Update(objUser);

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ReadKey();
        Console.ResetColor();
    }

    // DELETAR USUÁRIO
    void DeleteUsuario(UsuarioDAO userDao)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\n----------- DELETAR USUÁRIO -----------");
            Console.ResetColor();
            
            Console.Write("\nDigite o ID do usuário que deseja excluir: ");
            int id = Convert.ToInt32(Console.ReadLine());

            userDao.Delete(id);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ReadKey();
            Console.ResetColor();
        }

        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($"\nErro ao excluir usuário: {ex.Message}");
            Console.ResetColor();
        }
    }

    /*
    // CADASTRAR FUNCIONÁRIO
    void CadFuncionario()
    {
        var listEndDAO = objEndDAO.GetAll();

        Funcionario objFun = new Funcionario();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRA FUNCIONÁRIO -----------");
        Console.ResetColor();

        Console.Write("\nInforme o nome do funcionário: ");
        objFun.Nome = Console.ReadLine();

        Console.Write("Informe o telefone: ");
        objFun.Telefone = Console.ReadLine();

        Console.Write("Informe o email: ");
        objFun.Email = Console.ReadLine();

        Console.Write("Informe o CPF: ");
        objFun.Cpf = Console.ReadLine();

        Console.WriteLine("\nSelecione o cargo:");
        int cont = 0;

        foreach (var c in listCargo)
        {
            Console.WriteLine($"{cont + 1} - {c.Nome}");
            cont++;
        }

        int cargoSel = Convert.ToInt32(Console.ReadLine()) - 1;
        objFun.Id_Cargo = listCargo[cargoSel].Id_Cargo;

        Console.WriteLine("\nSelecione o endereço: ");
        int contEnd = 0;

        foreach (var end in listEndDAO)
        {
            Console.WriteLine($"\n{contEnd + 1} - {end.Estado}, {end.Cidade}, {end.Bairro}, {end.Rua} - {end.NumCasa}");
            contEnd++;
        }

        int enderecoSelecionado = Convert.ToInt32(Console.ReadLine()) - 1;
        objFun.Id_Endereco = listEndDAO[enderecoSelecionado].Id_Endereco;

        listFunc.Add(objFun);

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR FUNCIONÁRIO
    void ConsFuncionario()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR FUNCIONÁRIO -----------");
        Console.ResetColor();

        foreach (var f in listFunc)
        {
            Console.WriteLine($"\nID: {f.Id_Funcionario}");
            Console.WriteLine($"Nome: {f.Nome}");
            Console.WriteLine($"Telefone: {f.Telefone}");
            Console.WriteLine($"Email: {f.Email}");
            Console.WriteLine($"CPF: {f.Cpf}");
            Console.WriteLine($"Cargo: {f._Cargo.Nome}\n");

            Console.WriteLine("ENDEREÇO ----------------------------------");
            Console.WriteLine($"\nEstado: {f._Endereco.Estado}");
            Console.WriteLine($"Cidade: {f._Endereco.Cidade}");
            Console.WriteLine($"Bairro: {f._Endereco.Bairro}");
            Console.WriteLine($"Rua: {f._Endereco.Rua}");
            Console.WriteLine($"Nº:{f._Endereco.NumCasa}");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR EDITORA
    void CadEditora()
    {
        var listEndDAO = objEndDAO.GetAll();

        Editora e = new Editora();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR EDITORA -----------");
        Console.ResetColor();

        Console.Write("\nInforme o nome fantasia da editora: ");
        e.NomeFantasia = Console.ReadLine();

        Console.Write("Informe o telefone: ");
        e.Telefone = Console.ReadLine();

        Console.Write("Informe o CNPJ: ");
        e.Cnpj = Console.ReadLine();

        Console.Write("Informe o email: ");
        e.Email = Console.ReadLine();

        Console.WriteLine("\nSelecione o endereço:");
        int cont = 0;

        foreach (var end in listEndDAO)
        {
            Console.WriteLine($"{cont + 1} - {end.Estado}, {end.Cidade}, {end.Bairro}, {end.Rua}, Nº {end.NumCasa}");
            cont++;
        }

        int op = Convert.ToInt32(Console.ReadLine()) - 1;
        e.Id_Endereco = listEndDAO[op].Id_Endereco;

        listEditora.Add(e);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR EDITORA
    void ConsEditora()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR EDITORA -----------");
        Console.ResetColor();

        foreach (var e in listEditora)
        {
            Console.WriteLine($"\nID: {e.Id_Editora}");
            Console.WriteLine($"Nome Fantasia: {e.NomeFantasia}");
            Console.WriteLine($"Telefone: {e.Telefone}");
            Console.WriteLine($"CNPJ: {e.Cnpj}");
            Console.WriteLine($"Email: {e.Email}\n");

            Console.WriteLine("ENDEREÇO ----------------------------------");
            Console.WriteLine($"\nEstado: {e._Endereco.Estado}");
            Console.WriteLine($"Cidade: {e._Endereco.Cidade}");
            Console.WriteLine($"Bairro: {e._Endereco.Bairro}");
            Console.WriteLine($"Rua: {e._Endereco.Rua}");
            Console.WriteLine($"Nº:{e._Endereco.NumCasa}");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR LIVRO
    void CadLivro()
    {
        Livro objLivro = new Livro();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR LIVRO -----------");
        Console.ResetColor();

        Console.Write("\nInforme o título do livro: ");
        objLivro.Titulo = Console.ReadLine();

        Console.Write("Informe o ano de publicação: ");
        objLivro.AnoPubli = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSelecione a categoria:");
        int contCat = 0;

        foreach (var c in listCategoria)
        {
            Console.WriteLine($"{contCat + 1} - {c.Nome}");
            contCat++;
        }

        int catSel = Convert.ToInt32(Console.ReadLine()) - 1;
        objLivro.Id_Categoria = listCategoria[catSel].Id_Categoria;

        Console.WriteLine("\nSelecione a editora:");
        int contEdit = 0;

        foreach (var ed in listEditora)
        {
            Console.WriteLine($"{contEdit + 1} - {ed.NomeFantasia}");
            contEdit++;
        }

        int editSel = Convert.ToInt32(Console.ReadLine()) - 1;
        objLivro.Id_Editora = listEditora[editSel].Id_Editora;

        listLivro.Add(objLivro);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR LIVRO
    void ConsLivro()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR LIVRO -----------");
        Console.ResetColor();

        foreach (var l in listLivro)
        {
            Console.WriteLine($"\nID: {l.Id_Livro}");
            Console.WriteLine($"Título: {l.Titulo}");
            Console.WriteLine($"Ano: {l.AnoPubli}");
            Console.WriteLine($"Categoria: {l.Id_Categoria}");
            Console.WriteLine($"Editora: {l.Id_Editora}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR EXEMPLAR
    void CadExemplar()
    {
        Exemplar ex = new Exemplar();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR EXEMPLAR -----------");
        Console.ResetColor();

        Console.WriteLine("\nSelecione o livro:");
        int contLivro = 0;

        foreach (var l in listLivro)
        {
            Console.WriteLine($"{contLivro + 1} - {l.Titulo}");
            contLivro++;
        }

        int livroSel = Convert.ToInt32(Console.ReadLine()) - 1;
        ex.Id_Livro = listLivro[livroSel].Id_Livro;

        Console.WriteLine("\nSelecione o status:");
        int contStatus = 0;

        foreach (var s in listStatus)
        {
            Console.WriteLine($"{contStatus + 1} - {s.Situacao}");
            contStatus++;
        }

        int statusSel = Convert.ToInt32(Console.ReadLine()) - 1;
        ex.Id_Status = listStatus[statusSel].Id_Status;

        listExemplar.Add(ex);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR EXEMPLAR
    void ConsExemplar()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR EXEMPLAR -----------");
        Console.ResetColor();

        foreach (var l in listExemplar)
        {
            Console.WriteLine($"\nID: {l.Id_Exemplar}");
            Console.WriteLine($"Livro: {l.Id_Livro}");
            Console.WriteLine($"Status: {l.Id_Status}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR EMPRÉSTIMO
    void CadEmprestimo()
    {
        var listUserDAO = objUserDAO.GetAll();

        Emprestimo objEmp = new Emprestimo();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADASTRAR EMPRÉSTIMO -----------");
        Console.ResetColor();

        Console.WriteLine("\nSelecione o usuário:");
        int contUser = 0;

        foreach (var u in listUserDAO)
        {
            Console.WriteLine($"{contUser + 1} - {u.Nome}");
            contUser++;
        }

        int userSel = Convert.ToInt32(Console.ReadLine()) - 1;
        objEmp.Id_Usuario = listUserDAO[userSel].Id_Usuario;

        Console.WriteLine("\nSelecione o exemplar:");
        int contExp = 0;

        foreach (var exm in listExemplar)
        {
            Console.WriteLine($"{contExp + 1} - Exemplar {exm.Id_Exemplar}");
            contExp++;
        }

        Console.WriteLine("");

        int expSel = Convert.ToInt32(Console.ReadLine()) - 1;
        objEmp.Id_Exemplar = listExemplar[expSel].Id_Exemplar;

        Console.Write("Informe a data do empréstimo: ");
        objEmp.Data_Emprestimo = DateOnly.Parse(Console.ReadLine());

        Console.Write("Informe a data de devolução: ");
        objEmp.Data_Devolucao = DateOnly.Parse(Console.ReadLine());

        listEmprestimo.Add(objEmp);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR EMPRÉSTIMO
    void ConsEmprestimo()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR EMPRÉSTIMO -----------");
        Console.ResetColor();

        foreach (var l in listEmprestimo)
        {
            Console.WriteLine($"\nID: {l.Id_Emprestimo}");
            Console.WriteLine($"Usuário: {l.Id_Usuario}");
            Console.WriteLine($"Exemplar: {l.Id_Exemplar}");
            Console.WriteLine($"Data Empréstimo: {l.Data_Emprestimo}");
            Console.WriteLine($"Data Devolução: {l.Data_Devolucao}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }



    // CADASTRAR AUTOR_LIVRO
    void CadAutorLivro()
    {
        Autor_Livro al = new Autor_Livro();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CADOSTRAR AUTOR_LIVRO -----------");
        Console.ResetColor();

        Console.WriteLine("\nSelecione o autor:");
        int contAu = 0;

        foreach (var a in listAutor)
        {
            Console.WriteLine($"{contAu + 1} - {a.Nome}");
            contAu++;
        }

        int aSel = Convert.ToInt32(Console.ReadLine()) - 1;
        al.Id_Autor = listAutor[aSel].Id_Autor;

        Console.WriteLine("\nSelecione o livro:");
        int contLiv = 0;

        foreach (var l in listLivro)
        {
            Console.WriteLine($"{contLiv + 1} - {l.Titulo}");
            contLiv++;
        }

        int lSel = Convert.ToInt32(Console.ReadLine()) - 1;
        al.Id_Livro = listLivro[lSel].Id_Livro;

        listAutorLivro.Add(al);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
        Console.ResetColor();
    }

    // CONSULTAR AUTOR_LIVRO
    void ConsAutorLivro()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("\n----------- CONSULTAR AUTOR_LIVRO -----------");
        Console.ResetColor();

        foreach (var l in listAutorLivro)
        {
            Console.WriteLine($"\nAutor: {l.Id_Autor}");
            Console.WriteLine($"Livro: {l.Id_Livro}\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nClique em qualquer tecla para voltar ao Menu!\n");
            Console.ResetColor();
        }
    }
    */
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}