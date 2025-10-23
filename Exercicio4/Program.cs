int senha = 1234;
int senhaDigitada;

void VerificarSenha()
{

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
}

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Analisador de senhas");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha uma opção do menu abaixo");
Console.WriteLine("1 - Consultar senha");
int opçãoEscolhida = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

if (opçãoEscolhida == 1)
{
    VerificarSenha();
}

else
{
    Console.WriteLine("Opção INVALIDA");
}