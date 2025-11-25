using Encapsulamento;


/* CONTA BANCARIA

float dinheiro = 200;


ContaBancaria contaLucas = new ContaBancaria(dinheiro);
ContaBancaria contaFelipe = new ContaBancaria();

System.Console.WriteLine($"Saldo da Conta R$ {contaLucas.GetSaldo()}");
System.Console.WriteLine($"Saldo da Conta R$ {contaFelipe.GetSaldo()}");

*/

// -- CARRO


Carro C1 = new Carro();

C1.DefinirMarca("Red Bull Racing");
C1.DefinirModelo("RB22");
C1.DefinirVelocidade(360);

C1.ObterVelocidade();

C1.Acelerar(12);

C1.ObterVelocidade();

C1.Freiar(72);

C1.ObterVelocidade();