using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Retângulo
    {
        public double Largura;
        public double Altura;
        public Retângulo(double l, double h)
        {
            Largura = l;
            Altura = h;
        }
        public Retângulo()
        {
            Largura = 1;
            Altura = 1;
        }
        public void AreaRetangulo()
        {
            double Area = Altura * Largura;
        }
    }
}