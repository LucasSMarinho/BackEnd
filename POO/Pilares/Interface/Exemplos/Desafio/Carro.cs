using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Carro :   IMotor
    {
        public void acelerar()
        {
           Console.WriteLine("Vrummm!");
        }
    }
}