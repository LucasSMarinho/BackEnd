using Exercicio5;

ContaPoupança ContaP1 = new ContaPoupança();

ContaP1.Depositar(100);

System.Console.WriteLine(ContaP1.Saldo);
System.Console.WriteLine();
ContaP1.CalcularRendimento();

System.Console.WriteLine(ContaP1.Saldo);
System.Console.WriteLine();