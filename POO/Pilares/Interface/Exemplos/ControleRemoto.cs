using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if(NivelVolume == VolumeMaximo)
            {
            System.Console.WriteLine("Volume maximo já alcançado");
            }
            else
            {
            NivelVolume++;
            System.Console.WriteLine("Volume atual: {NivelVolume}");
            }      
        }

        public void Desligar()
        {
            System.Console.WriteLine("Desligando a Tv");
        }

        public void DiminuirVolume()
        {
            if(NivelVolume == 0)
            {
            System.Console.WriteLine("Volume minimo já alcançado");
            }
            else
            {
            NivelVolume--;
            System.Console.WriteLine("Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
            System.Console.WriteLine("Ligando a Tv");
        }
    }
}