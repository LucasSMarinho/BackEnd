using System.Security.AccessControl;
using Exercicio1;

Circulo C1 = new Circulo();
Retangulo R1 = new Retangulo();
Triangulo T1 = new Triangulo();


Console.WriteLine("----------------------------------------------");
Console.WriteLine("Qual o raio do circulo");
C1.Raio = double.Parse(Console.ReadLine());
C1.CalcularArea();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Qual a altura do retângulo");
R1.Altura = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Qual a largura do retângulo");
R1.Largura = double.Parse(Console.ReadLine());
R1.CalcularArea();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Qual a altura do triângulo");
T1.Altura = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Qual a base do triângulo");
T1.Base = double.Parse(Console.ReadLine());
T1.CalcularArea();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine();