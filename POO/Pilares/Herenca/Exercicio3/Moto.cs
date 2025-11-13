using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Moto : Veiculos
    {
        public int Velocidade;
        public override void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");  
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"modelo: {Modelo}");
            Console.WriteLine($"Velocidade Maxima: {Velocidade}");
            Console.WriteLine($"--------------------------------");
        }
    }
}