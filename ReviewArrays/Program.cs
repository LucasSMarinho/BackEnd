// See https://aka.ms/new-console-template for more information
int opcao , totalAlunos = 0;
string[] nomes = new string[4];
int[] idades = new int[4];


Console.Clear();

do
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Escolha uma das opções abaixo");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($" 1 - Cadastrar alunos");
    Console.WriteLine($" 2 - Listar alunos");
    Console.WriteLine($" 3 - Opção");
    Console.WriteLine($" 4 - Opção");
    Console.WriteLine($" 0 - Sair");
    Console.WriteLine("----------------------------------------------------------------");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Obrigado por usar nosso programa");
            Console.WriteLine();
            Console.Write($"Encerrando");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            
             break;
        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;
    }

} while (opcao != 0);



Console.WriteLine();

//    =================================(Funções)=================================

void CadastrarAluno ()
{
    //verificar se tem espaço no array
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Digite quantos alunos você gostaria de cadastrar?");
    Console.WriteLine("----------------------------------------------------------------");
    int n = int.Parse(Console.ReadLine());

    if (totalAlunos + n > 4)
    {
        Console.WriteLine("Limite de ocupação atingido");
        return;
    }
    else
    {
        do
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Digite o nome do aluno");
            Console.WriteLine("----------------------------------------------------------------");
            nomes[totalAlunos] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Digite a idade do(a) {nomes[totalAlunos]}");
            Console.WriteLine("----------------------------------------------------------------");
            idades[totalAlunos] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            totalAlunos++;

            Console.WriteLine($"Aluno cadastrado com sucesso");
            Console.WriteLine($"Agora há {totalAlunos} cadastrados no sistema");
            Console.WriteLine();
            n--;

        } while (n != 0);

            Console.Write("Para continuar precione a tecla <Enter>");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
    }
}

void ListarAlunos()
{
    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{nomes[i]} - {idades[i]} anos");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    };
    Console.Write("Para continuar precione a tecla <Enter>");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
    Console.Write($".");
    Console.ReadLine();
}