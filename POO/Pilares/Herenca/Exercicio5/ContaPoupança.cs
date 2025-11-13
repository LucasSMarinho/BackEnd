using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class ContaPoupança : ContaBancaria
    {
        public void CalcularRendimento()
        {
            Saldo += Saldo * 0.02;
        }
    }
}