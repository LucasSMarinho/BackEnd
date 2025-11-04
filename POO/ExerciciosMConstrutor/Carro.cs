using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
 public class Carro
    {
        //propriedades
        public string Marca = "";
        public string Modelo = "";
        public int Ano;

        public Carro(string M, string Mol, int A)
        {
            Marca = M;
            Modelo = Mol;
            Ano = A;
        }

        public void DadosCarro()
        {
            Console.WriteLine($"------------|Carro:{Marca}|------------");
            Console.WriteLine($"Quantidade de Portas: {Modelo}");
            Console.WriteLine($"Quantidade de rodas: {Ano}");
            Console.WriteLine($"-------------------------------------------------");
        }
    }
}