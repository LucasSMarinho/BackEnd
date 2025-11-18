using Exercicio2;

List<IImprimivel> Documentos = new List<IImprimivel>();


//MENU

int opção = -1;

do{
System.Console.WriteLine($"Menu de opções");
System.Console.WriteLine($@"
-------------------------------------
1 - Cadastrar Fatura
2 - Cadastrar Relatório
3 - Cadastrar Contrato
4 - Listar Faturas
5 - Listar Relatórios
6 - Listar Contratos
0 - Sair
-------------------------------------

opção = int.Parse(Console.ReadLine());
");

switch (opção)
{
    case 1:
        CadastrarFatura();
        break;
    case 2:
        CadastrarRelatorio();
        break;
    case 3:
        CadastrarContrato();
        break;
    case 4:
        ListarFaturas();
        break;
    case 5:
        ListarRelatorios();
        break;
    case 6:
        ListarContratos();
        break;
    case 0:
        Console.WriteLine("Saindo");
        opção = 0;
        break;
    default:
        Console.WriteLine("Opção invalida");
    break;
}


System.Console.WriteLine($"Digite <enter> para continuar");
Console.ReadLine();

} while(opção != 0);







//Funções auxiliares





void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor");
    string dev = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o valor (R$)");
    double valor = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Dias atrasados");
    int diasAtraso = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Fatura F = new Fatura(dev, cred, valor, diasAtraso);
    Documentos.Add(F);
}


void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante");
    string contratante = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do PrestadorServiso");
    string PrestadorServiso = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite as  clausulas");
    string TextoClausulas = Console.ReadLine();
    Console.WriteLine();

    Contrato C = new Contrato(contratante, PrestadorServiso, TextoClausulas);
    Documentos.Add(C);
}


void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do autor do relatorio");
    string Nome = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o texto relatorio");
    string TextoRelatorio = Console.ReadLine();
    Console.WriteLine();

    Relatorio R = new Relatorio(Nome, TextoRelatorio);
    Documentos.Add(R);
}

void ListarFaturas()
{
foreach (var item in Documentos)
{
    if(item is Fatura)
    {
    Console.WriteLine("-------------------------------------------------");
    item.Imprimir();
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    }
}
}


void ListarContratos()
{
foreach (var item in Documentos)
{
    if(item is Contrato)
    {
    Console.WriteLine("-------------------------------------------------");
    item.Imprimir();
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    }
}
}


void ListarRelatorios()
{
foreach (var item in Documentos)
{
    Console.WriteLine("-------------------------------------------------");
    item.Imprimir();
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
}
}