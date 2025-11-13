using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{

    public class ContaPoupança : ContaBancaria
    {

    private double TaxaSaque = 1.02;
    private double TaxaDeposito = 1.05;

        public override void Depositar(double Deposito)
        {
            Saldo += Deposito * TaxaDeposito;
        }
        public override void Sacar(double Saque)
        {
            if( Saque <= (Saldo * TaxaSaque))
            {
               Saldo -= Saque * TaxaSaque;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}