using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herenca
{
    public class Cachorro : Animal
    {
        public override void FazerSons()
        {
            Console.WriteLine("au, au!");
        }
    }
}