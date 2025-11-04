using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Livro
    {
        public string Titulo = "";
        public string Autor = "";
        public double Preco;

        public Livro(string t, string a, double p)
        {
            Titulo = t;
            Autor = a;
            Preco = p;
        }
        
        public Livro (string t, string a)
        {
            Titulo = t;
            Autor = a;
            Preco = 0;
        }
    }
}