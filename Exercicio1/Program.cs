double salario;
double gasto;
double resultado;


void GastoFinal ()
{
    if (salario >= gasto)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Gastos dentro do orçamento");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"orçamento ESTOURADO em {resultado}!!");
        Console.WriteLine("----------------------------------------------------------------");
    }
}

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Analisador de gastos");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha uma opção do menu abaixo");
Console.WriteLine("1 - Consultar gastos");
int opçãoEscolhida = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

if (opçãoEscolhida == 1)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Digite seu salário");
    salario = double.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Digite seu gasto");
    gasto = double.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");

    resultado = -1 * (salario - gasto);

    GastoFinal();
}
else
{
    Console.WriteLine("Opção INVALIDA");
}