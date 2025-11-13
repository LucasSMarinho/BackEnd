using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class ContaBancaria
    {
        public double Saldo = 0;

        public abstract void Depositar(double Deposito);
        public abstract void Sacar(double Saque);
    }
}