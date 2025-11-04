using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        string Nome;
        int Idade;

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos");
        }
    }

}