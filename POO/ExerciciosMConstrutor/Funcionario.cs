using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Funcionario
    {
        public string Nome = "";
        public string Cargo = "";
        public double Salario;

        public Funcionario(string n)
        {
            Nome = n;
        }

        public Funcionario(string n, string c)
        {
            Nome = n;
            Cargo = c;
        }

        public Funcionario(string n, string c, double s)
        {
            Nome = n;
            Cargo = c;
            Salario = s;
        }
        
    }
}