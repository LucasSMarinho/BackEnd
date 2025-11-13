using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Depositar(double Deposito)
        {
            if(Deposito > 0)
            {
            Saldo += Deposito;
            } 
        }
        public override void Sacar(double Saque)
        {
            if( Saque <= Saldo)
            {
               Saldo -= Saque;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}