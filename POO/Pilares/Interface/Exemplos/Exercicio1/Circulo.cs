using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Circulo : IForma
    {
    private double PI = Math.PI;

    public double Raio;
        public void CalcularArea()
        {
            double AreaTotal = PI * (Raio * Raio);
            Console.WriteLine($"A area do circulo é: {AreaTotal}");
        }
    }
}