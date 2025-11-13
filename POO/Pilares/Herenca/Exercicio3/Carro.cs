using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3;
{
    public class Carro : Veiculos
    {
        public int QtdPortas;
        public override void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");  
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"modelo: {Modelo}");
            Console.WriteLine($"Quantidade de Portas: {QtdPortas}");
            Console.WriteLine($"--------------------------------");
        }
    }
}