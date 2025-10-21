// See https://aka.ms/new-console-template for more information
/*pedir o nome do usuário, dois números e mostrar a soma dos numeros no final*/

using System.Collections;
using System.Formats.Asn1;
using System.Net.WebSockets;
using System.Reflection;

string nome;
int n1;
int n2;

//criando funções


//pedir os dados
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite o segundo numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


if (n1 > n2)
{
    Console.WriteLine($"o primeiro numero é maior: {n1}"); //interpolação
}

else if (n2 > n1)

{
    Console.WriteLine($"o segundo numero é maior: {n2}"); //interpolação 
}

else
{
    Console.WriteLine($"os dois numeros são iguais");
};






//para falar qual numero é maior
/*
if (n1 > n2)
{
    Console.WriteLine($"o primeiro numero é maior: " + n1); //interpolação
}

else
{
    Console.WriteLine($"o segundo numero é maior: {n2}"); //interpolação 
}
*/