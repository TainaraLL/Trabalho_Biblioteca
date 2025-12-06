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

        Console.WriteLine("1- ");
        Console.WriteLine("2- ");
        Console.WriteLine("3- ");
        Console.WriteLine("4- ");
        Console.WriteLine("5- ");
        Console.WriteLine("6- ");
        Console.WriteLine("7- ");
        Console.WriteLine("8- ");
        Console.WriteLine("9- ");

        Console.Write("\nEscolha uma das opções: ");
        opc = Convert.ToInt16(Console.ReadLine());

        switch (opc)
        {
            case 1: 
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                break;

            case 6:
                break;

            case 7:
                break;

            case 8:
                break;

            case 9:
                break;
        }

    } while (opc == 0);

    void CadUsuario()
    {
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
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}