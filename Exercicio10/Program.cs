// See https://aka.ms/new-console-template for more information
void Exercicio1()
{
    double salario;
    double gasto;
    double resultado;

    void GastoFinal()
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


void Exercicio2()
{

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
    Console.WriteLine();

    ChecarPlacar();

}

void Exercicio3()
{
    int medida1;
    int medida2;
    int medida3;

    void ConsultarTriangulo()
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("A medida do primeiro lado é?");
        medida1 = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("A medida do primeiro lado é?");
        medida2 = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("A medida do primeiro lado é?");
        medida3 = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------------------");

        if (medida1 + medida2 + medida3 == 180)
        {
            if (medida1 == medida2 && medida1 == medida3)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("O triângulo é equilátero");
                Console.WriteLine("----------------------------------------------------------------");
            }
            else if (medida1 == medida2 || medida2 == medida3 || medida3 == medida1)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("O triângulo é isósceles");
                Console.WriteLine("----------------------------------------------------------------");
            }
            else if (medida1 != medida2 && medida2 != medida3 && medida3 != medida1)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("O triângulo é escaleno");
                Console.WriteLine("----------------------------------------------------------------");
            }
        }
        else
        {

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ISSAS NÃO SÃO MEDIDAS DE TRIANGULOS!!!");
            Console.WriteLine("----------------------------------------------------------------");

        }
    }


    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Analisador de triângulos");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Escolha uma opção do menu abaixo");
    Console.WriteLine("1 - Consultar triângulo");
    int opçãoEscolhida = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();

    ConsultarTriangulo();
}


void Exercicio4()
{
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

    VerificarSenha();


}

void Exercicio5()
{
    int numeroMacaComprada;
    double preco = 0;

    void VerificarMacas()
    {

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Digite quantas maças o cliente comprou");
        numeroMacaComprada = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------------------");


        if (numeroMacaComprada < 12)
        {
            preco = numeroMacaComprada * 0.30;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("DESCONTO NÃO APLICADO");
            Console.WriteLine($"O cliente comprou {numeroMacaComprada} maças");
            Console.WriteLine($"A preço total é: {preco}");
            Console.WriteLine("----------------------------------------------------------------");
        }
        else
        {
            preco = numeroMacaComprada * 0.25;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("DESCONTO NÃO APLICADO");
            Console.WriteLine($"O cliente comprou {numeroMacaComprada} maças");
            Console.WriteLine($"A preço total é: {preco}");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
    ;

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Media dos alunos");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Escolha uma opção do menu abaixo");
    Console.WriteLine("1 - Consultar preço");
    int opçãoEscolhida = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();

    VerificarMacas();
}

void Exercicio6()
{
    double nota1, nota2, nota3, nota4;
    double media;
    int frequência;

    void MediaAluno()
    {

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

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("digite a frequência do aluno");
        frequência = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();

        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media < 3 || frequência < 75)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("O aluno está REPROVADO");
            Console.WriteLine($"Nota: {media}");
            Console.WriteLine($"Frequência: {frequência}%");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }

        else if (media >= 3)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("O aluno está de recuperação");
            Console.WriteLine($"Nota: {media}");
            Console.WriteLine($"Frequência: {frequência}%");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("O aluno foi APROVADO");
            Console.WriteLine($"Nota: {media}");
            Console.WriteLine($"Frequência: {frequência}%");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }
    }

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Mercadinho");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Escolha uma opção do menu abaixo");
    Console.WriteLine("1 - Consultar preço");
    int opçãoEscolhida = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine();

    MediaAluno();

}

Console.Clear();
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Escolha um exercicio para rodar");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("1 - Exercicio 1: Analisador de gastos");
Console.WriteLine("2 - Exercicio 2: Analisador de Score");
Console.WriteLine("3 - Exercicio 3: Analisador de triângulos");
Console.WriteLine("4 - Exercicio 4: Analisador de senha");
Console.WriteLine("5 - Exercicio 5: Mercadinho");
Console.WriteLine("6 - Exercicio 6: Media dos alunos");
Console.WriteLine("0 - Sasir");
int opçãoEscolhida = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

do

{
    switch (opçãoEscolhida)
    {
        case 1:
            Exercicio1();
            break;
        case 2:
            Exercicio2();
            break;
        case 3:
            Exercicio3();
            break;
        case 4:
            Exercicio4();
            break;
        case 5:
            Exercicio5();
            break;
        case 6:
            Exercicio6();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
} while (opçãoEscolhida != 0);