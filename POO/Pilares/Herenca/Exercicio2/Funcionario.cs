using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Funcionario
    {
        public string Nome = " ";
        public double SalarioBase = 10000;

        public virtual void CalcularSalario()
        {
            
        }
        public void MostrarSalario()
        {
            System.Console.WriteLine(SalarioBase);
        }
    }
}