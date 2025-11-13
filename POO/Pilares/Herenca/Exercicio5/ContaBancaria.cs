using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class ContaBancaria
    {
        public int Numero = 0;
        public double Saldo = 0;

        public void Depositar(double Deposito)
        {
            Saldo += Deposito;
        }
        public void Sacar(double Saque)
        {   
            if(Saque <= Saldo)
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