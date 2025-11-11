using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao : Veiculo
    {
        public int QtdTurbinas;

        public void LevantarVoo()
        {
            Console.WriteLine($"Avião levantando voo");
        }
        public void Pousar()
        {
            Console.WriteLine($"Avião pousando");  
        }
    }
}