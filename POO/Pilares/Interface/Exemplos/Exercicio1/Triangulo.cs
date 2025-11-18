using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Triangulo : IForma
    {
    public double Altura;

    public double Base;
        public void CalcularArea()
        {
            double AreaTotal = (Altura * Base)/2;
            Console.WriteLine($"A area do triângulo é: {AreaTotal}");
        }
    }
}