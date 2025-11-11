using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herenca
{
    public class Gato : Animal
    {
        public override void FazerSons()
        {
            Console.WriteLine("miau!");
        }
    }
}