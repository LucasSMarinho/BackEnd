int senha = 1234;
int senhaDigitada;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Porfavor, digite a sua senha");
senhaDigitada = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");




if (senhaDigitada == senha)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("-- ACESSO   PERMITIDO --");
    Console.WriteLine("----------------------------------------------------------------");
}
else
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("-- ACESSO   NEGADO --");
    Console.WriteLine("----------------------------------------------------------------");
}


