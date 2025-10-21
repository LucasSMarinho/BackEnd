int golsT1;
int golsT2;

void ChecarPlacar()
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("A quantidade de gols do primeiro time");
    golsT1 = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("A quantidade de gols do segundo time");
    golsT2 = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");

    if (golsT1 > golsT2)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O time 1 ganhou");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else if (golsT1 == golsT2)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O jogo deu em empate");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("O time 2 ganhou");
        Console.WriteLine("----------------------------------------------------------------");
    }
}

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Analisador de score");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha uma opção do menu abaixo");
Console.WriteLine("1 - Consultar gastos");
int opçãoEscolhida = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

if (opçãoEscolhida == 1)
{
    ChecarPlacar();
}
else
{
    Console.WriteLine("Opção INVALIDA");
}