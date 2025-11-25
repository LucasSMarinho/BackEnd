using System.Runtime.InteropServices;
using ClassesEstaticas;

Console.WriteLine($"Digite um numero");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro numero");
float n2 = float.Parse(Console.ReadLine());

if(n1 == n2)
{
    System.Console.WriteLine("Os numeros são iguais");
}
else
{
Console.WriteLine($"O maior numero é: {CalculosMatematicos.Maior(n1, n2)}"); 
Console.WriteLine($"O menor numero é: {CalculosMatematicos.Menor(n1, n2)}"); 
}