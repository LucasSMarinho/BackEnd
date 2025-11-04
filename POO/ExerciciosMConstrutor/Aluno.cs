using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Aluno
    {
        public string Nome = "";

        public double Nota;


public Aluno(string N, double G)
        {
            Nome = N;
            Nota = G;
        }
        public Aluno()
        {
            Nome = "Inderteminado";
            Nota = 0;
        }
    }
}