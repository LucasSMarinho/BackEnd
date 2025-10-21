// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

int n = 0;
int resultado = 0;

for (int i = 1; i <= 3; i++)
{
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"digite o {i}° numero");
Console.WriteLine("----------------------------------------------------------------");
    n = int.Parse(Console.ReadLine());
    resultado += n;

};


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"a soma dos numeros que você digitou é: {resultado}");
Console.WriteLine("----------------------------------------------------------------");
