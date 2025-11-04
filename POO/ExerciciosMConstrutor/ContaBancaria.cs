using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class ContaBancaria
    {
        public string Titular = "";
        public double Saldo;

        public ContaBancaria(string T)
        {
            Titular = T;

            Saldo = 0;
        }

        public ContaBancaria(string T, double S)
        {
            Titular = T;

            Saldo = S;
        }
    }
}