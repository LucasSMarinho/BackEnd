using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Herenca
{
    public class Gerente : Funcionario
    {
        public double Bonus = 0.6;

        public override void CalcularSalario()
        {
           SalarioBase += SalarioBase * Bonus;
        }
    }
}