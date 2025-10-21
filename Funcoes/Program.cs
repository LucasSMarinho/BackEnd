String nome;
String sobrenome;

Console.Clear();

void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia");
};


void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {nomeRecebido}");
};


void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {sobrenomeRecebido}");
};


string SaudarNomeCompleto (string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
};


void OpcaoInvalida()
{
    Console.WriteLine($"-- OPÇÃO INVALIDA --");
};

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Porfavor insira seu nome");
Console.WriteLine("----------------------------------------------------------------");
nome = Console.ReadLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Porfavor insira seu sobrenome");
Console.WriteLine("----------------------------------------------------------------");
sobrenome = Console.ReadLine();


Console.WriteLine($"ok, {nome}! Agora vamoes dar as boas vindas a você!!!");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha uma das opções abaixo");
Console.WriteLine("1 - Saudar com nome"); //receba o nome por parâmetro e digitar a saudação dentro da função
Console.WriteLine("2 - Saudar com sobrenome"); //receba o sobrenome por parâmetro e digitar a saudação dentro da função
Console.WriteLine("3 - Saudar com nome e sobrenome");
Console.WriteLine("0 - apenas saudação genérica"); //delvolve um texto de saudação genérico
Console.WriteLine("----------------------------------------------------------------");

int opção = 0;
opção = int.Parse(Console.ReadLine());

switch (opção)
{
    case 0:
        Console.WriteLine("----------------------------------------------------------------");
        SaudacaoGenerica();
        Console.WriteLine("----------------------------------------------------------------");
        break;
    case 1:
        Console.WriteLine("----------------------------------------------------------------");
        SaudarComNome(nome);
        Console.WriteLine("----------------------------------------------------------------");
        break;
    case 2:
        Console.WriteLine("----------------------------------------------------------------");
        SaudarComSobrenome(sobrenome);
        Console.WriteLine("----------------------------------------------------------------");
        break;
    case 3:
        Console.WriteLine("----------------------------------------------------------------");
        string nomeCompleto = SaudarNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem-vindo {nomeCompleto}");
        Console.WriteLine("----------------------------------------------------------------");
        break;
    default:
        Console.WriteLine("----------------------------------------------------------------");
        OpcaoInvalida();
        Console.WriteLine("----------------------------------------------------------------");
    break;
}