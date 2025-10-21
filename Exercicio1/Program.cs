double salario;
double gasto;
double resultado;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Digite seu salário"); 
salario = double.Parse(Console.ReadLine()); 
Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Digite seu gasto"); 
gasto = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");

resultado = -1 * (salario - gasto);

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