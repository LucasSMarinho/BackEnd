// See https://aka.ms/new-console-template for more information

double nota1, nota2, nota3, nota4;
double media;



Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite a primeira nota");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("");


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite a segunda nota");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite a terceira nota");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite a quarta nota");
nota4 = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media >= 7)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("O aluno foi aprovado");
    Console.WriteLine($"Nota: {media}");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();
}

else if (media >= 5)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("O aluno está de recuperação");
    Console.WriteLine($"Nota: {media}");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();
}

else
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("O aluno está REPROVADO");
    Console.WriteLine($"Nota: {media}");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();
};
