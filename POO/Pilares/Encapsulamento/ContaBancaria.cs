using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial >=  0)
            {
            Saldo = saldoInicial;
            return;
            }
        }

        public void Depositar(float valor)
        {
            if(valor >=  0)
            {
            Saldo += valor;
            return;
            }
        }
        public void Sacar(float valor)
        {
            if(valor >=  0 && valor <= Saldo)
            {
            Saldo -= valor;
            return;
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }
    }
}