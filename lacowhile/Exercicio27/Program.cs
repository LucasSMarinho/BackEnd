// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

int n = 0;
int repetições;
int ndesejado;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digites quantos numeros vc quer digitar");
Console.WriteLine("----------------------------------------------------------------");
repetições = int.Parse(Console.ReadLine());
int[] numeros = new int[repetições];

while ((n+1) <= repetições)
{

    Console.WriteLine("digite o numero desejado");
    ndesejado = int.Parse(Console.ReadLine());
    if (ndesejado % 2 != 0)
    {
        //Console.WriteLine($"o numero digitado foi: {ndesejado}"); 
        numeros[n] = ndesejado;
    }
    else
    {
        Console.WriteLine($"você digitou um numero par: {ndesejado}");
    }
    n++;
};

n = 0;

Console.WriteLine("----------------------------------------------------------------");
while ( (n + 1) <= repetições)
{
    Console.WriteLine(numeros[n]);
    Console.WriteLine();
    n++;
};
Console.WriteLine("----------------------------------------------------------------");