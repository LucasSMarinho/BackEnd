using System.Collections.Concurrent;
using ClassesEObjetos;
int opçãoEscolhida;

do
{
    Console.Clear();
    Console.WriteLine("Porfavor escolha um dos exercicios");

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("1 - Garrafa");
    Console.WriteLine("2 - Pessoa");
    Console.WriteLine("3 - Conta Bancária");
    Console.WriteLine("4 - Produto com desconto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("----------------------------------------------------------------");


    opçãoEscolhida = int.Parse(Console.ReadLine());
    switch (opçãoEscolhida)

    {

        case 1:
            Garrafa G1 = new Garrafa();

            Console.WriteLine("Porfavor digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a marca da garrafa");
            G1.Marca = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a cor da garrafa");
            G1.Cor = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o material da garrafa");
            G1.Material = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite quantos litros a garrafa tem da garrafa");
            G1.VolumeLitros = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"----------Garrafa----------");
            Console.WriteLine($"Nome do usuario: {nome}");
            Console.WriteLine($"Marca da garrafa: {G1.Marca}");
            Console.WriteLine($"Material: {G1.Material}");
            Console.WriteLine($"Cor: {G1.Cor}");
            Console.WriteLine($"Capacidade: {G1.VolumeLitros}");
            Console.WriteLine($"-------------------------------");
            Console.WriteLine();
            Console.Write("Para continuar precione a tecla <Enter>");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Console.ReadLine();
            break;

        case 2:
            Pessoa P1 = new Pessoa();
            P1.Nome = "João Silva";
            int Idade = P1.Envelhecer(16);
            Console.WriteLine($"{P1.Nome} tem {P1.Idade} anos");
            Console.WriteLine();
            Console.Write("Para continuar precione a tecla <Enter>");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Console.ReadLine();
            break;

        case 3:

            ContaBancária C1 = new ContaBancária();
            Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine("Você deseja fazer um daque ou um deposito?");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1 - Deposito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("----------------------------------------------------------------");
            opçãoEscolhida = int.Parse(Console.ReadLine());

            if (opçãoEscolhida == 1)
            {
                System.Console.WriteLine("Quanto você deseja depositar");
                int D = int.Parse(Console.ReadLine());
                C1.Depositar(D);
                Console.WriteLine($"Saldo Atual: {C1.Saldo}");
                Console.WriteLine();
                Console.Write("Para continuar precione a tecla <Enter>");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Console.ReadLine();
            }
            else if (opçãoEscolhida == 2)
            {
                System.Console.WriteLine("Quanto você deseja sacar");
                int S = int.Parse(Console.ReadLine());
                C1.Sacar(S);
                Console.WriteLine($"Saldo Atual: {C1.Saldo}");
                Console.WriteLine();
                Console.Write("Para continuar precione a tecla <Enter>");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine($"Não temos essa opção saldo atual: {C1.Saldo}");
                Console.WriteLine();
                Console.Write("Para continuar precione a tecla <Enter>");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Thread.Sleep(500);
                Console.Write($".");
                Console.ReadLine();
            }

            break;

        case 4:
            ProdutoComDesconto P = new ProdutoComDesconto();
            System.Console.WriteLine("Porfavor digite o nome do produto");
            P.Nome = Console.ReadLine();
            Console.WriteLine();
            System.Console.WriteLine("Porfavor digite o preço do produto");
            P.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine();
            System.Console.WriteLine("Digite o desconto em %");
            int desconto = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            System.Console.WriteLine($"O preço do produto com desconto é de: {P.AplicarDesconto(desconto):F2}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Para continuar precione a tecla <Enter>");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Thread.Sleep(500);
            Console.Write($".");
            Console.ReadLine();
            break;

        case 0:
            Console.WriteLine("Obrigado por ultilizar o nosso codigo");
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;

    }
} while (opçãoEscolhida != 0);