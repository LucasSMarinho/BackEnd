using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class AlunoMedia
    {
        public string Nome = "";

        public double Nota1;
        public double Nota2;
        public double Nota3;


public AlunoMedia(string n, double n1, double n2, double n3)
        {
            Nome = n;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }
        public AlunoMedia()
        {
            Nome = "Indertemindado";
            Nota1 = 0;
            Nota2 = 0;
            Nota3 = 0;
        }
        public double MediaAluno()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}