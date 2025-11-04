using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        public Pessoa()
        {
            Nome = "indefinido";
            Idade = 0;
        }

        public Pessoa(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void MostrarDadosPessoa()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Idade);
        }
    }
}