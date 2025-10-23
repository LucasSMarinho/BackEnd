// See https://aka.ms/new-console-template for more information
int numeroMacaComprada;
double preco = 0;

void VerificarMacas()
{

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Digite quantas maças o cliente comprou");
    numeroMacaComprada = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");


    if (numeroMacaComprada < 12)
    {
        preco = numeroMacaComprada * 0.30;

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("DESCONTO NÃO APLICADO");
        Console.WriteLine($"O cliente comprou {numeroMacaComprada} maças");
        Console.WriteLine($"A preço total é: {preco}");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else
    {
        preco = numeroMacaComprada * 0.25;

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("DESCONTO NÃO APLICADO");
        Console.WriteLine($"O cliente comprou {numeroMacaComprada} maças");
        Console.WriteLine($"A preço total é: {preco}");
        Console.WriteLine("----------------------------------------------------------------");
    }
};

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Mercadinho");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha uma opção do menu abaixo");
Console.WriteLine("1 - Consultar preço");
int opçãoEscolhida = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


if (opçãoEscolhida == 1)
{
    VerificarMacas();
}

else
{
    Console.WriteLine("Opção INVALIDA");
}