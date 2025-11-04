using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Computador
    {
        public string Marca = "";
        public int MemoriaRam;
        public int Armazenamento;

        public Computador(string m, int mr, int a)
        {
            Marca = m;
            MemoriaRam = mr;
            Armazenamento = a;
        }
        
        public Computador ()
        {
            Marca = "Desconhecida";     
            MemoriaRam = 0;     
            Armazenamento = 0;     
        }
    }
}