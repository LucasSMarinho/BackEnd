// See https://aka.ms/new-console-template for more information
int numeroMacaComprada;
double preco = 0;

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