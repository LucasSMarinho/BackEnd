// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

int n = 0;
int n1 = 0;
int n2 = 0;
int repetições;
int ndesejado;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("quantas vezes vc quer repetir a comparação");
Console.WriteLine("----------------------------------------------------------------");
repetições = int.Parse(Console.ReadLine());
int[] numeros = new int[repetições];

while ((n + 1) <= repetições)
{

    Console.WriteLine("digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("digite o segundno numero");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (n1 > n2)
    {
        Console.WriteLine($"o primeiro numero é maior: {n1}");
        numeros[n] = n1;
    }
    else
    {
        Console.WriteLine($"o segundo numero é maior: {n2}");
        numeros[n] = n2;
    }
    n++;
}
;

n = 0;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Os maiores numeros digitados foram");
while ((n + 1) <= repetições)
{
    Console.WriteLine(numeros[n]);
    Console.WriteLine();
    n++;
}
;
Console.WriteLine("----------------------------------------------------------------");
