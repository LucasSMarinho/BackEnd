// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

string cargo;
double salario;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha a opção que representa seu cargo");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine(" | produção                                                   | ");
Console.WriteLine(" | administrativo                                             | ");
Console.WriteLine(" | diretoria                                                  | ");
Console.WriteLine("----------------------------------------------------------------");
cargo = Console.ReadLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine(" | Digite seu salario                                         | ");
salario = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

    if (cargo == "produção")
    {

    salario = salario * 1.065;
        Console.WriteLine($"Seu novo salario é: {salario}");

    }

    else if (cargo == "administrativo")
    {

    salario = salario * 1.075;
        Console.WriteLine($"Seu novo salario é: {salario}");

    }

    else if (cargo == "diretoria")

    {

    salario = salario * 1.12;
        Console.WriteLine($"Seu novo salario é: {salario}");

    }

    else
    {
        Console.WriteLine($"Cargo sem direito a reajuste: {salario}");
    }