using Exemplos;


// Cachorro Totó = new Cachorro();
// Gato Gatinho = new Gato();
// Pessoa Edu = new Pessoa();



ContaCorrente ContaC1 = new ContaCorrente();
ContaPoupança ContaP1 = new ContaPoupança();



ContaP1.Depositar(100);
System.Console.WriteLine($"Saldo da Conta: R$:{ContaP1.Saldo}");
ContaP1.Sacar(10);
System.Console.WriteLine($"Saldo da Conta: R$:{ContaP1.Saldo}");
