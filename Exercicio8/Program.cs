// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

int i = 0;
int opçãoEscolhida;
String nome;

//função

void ImprimirTexto(String texto)
{
    Console.WriteLine(texto);
}

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Bem-Vindo ao Beta do nosso menu");
Console.WriteLine("Porfavor digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"Olá, {nome}");
Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine("Escolha uma opção do menu abaixo");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("1 - Opção 1");
Console.WriteLine("2 - Opção 2");
Console.WriteLine("3 - Opção 3");
Console.WriteLine("4 - Sair");
Console.WriteLine("----------------------------------------------------------------");



do

{
    opçãoEscolhida = int.Parse(Console.ReadLine());
    switch (opçãoEscolhida)
    {

        case 1:
            Console.WriteLine("Você a escolheu primeira opção");

            break;
        case 2:
            Console.WriteLine("Você a escolheu segunda opção");
            break;

        case 3:
            Console.WriteLine("Você a escolheu terceira opção");
            break;

        case 4:
            Console.WriteLine("Você a escolheu quarteira opção");
            i++;
            break;

        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
} while (i < 1);
