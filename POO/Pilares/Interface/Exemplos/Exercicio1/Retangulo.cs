using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Retangulo : IForma
    {

    public double Altura = 0;

    public double Largura = 0;
        public void CalcularArea()
        {
            double AreaTotal = Altura * Largura;
            Console.WriteLine($"A area do Retângulo é: {AreaTotal}");
        }
    }
}