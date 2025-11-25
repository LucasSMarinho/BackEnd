using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Divisão(float a, float b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine($"Divisão invalida");
                return 0;
            }
        }

        public static float Maior(float a, float b)
        {
            return Math.Max(a, b);
        }

        public static float Menor(float a, float b)
        {
            return Math.Min(a, b);
        }
    }
}