using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herenca
{
    public class Veiculos
    {
        public string Marca = " ";
        public string Modelo = " ";

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, modelo: {Modelo}");
        }
    }
}