using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMConstrutor
{
    public class Produto
    {
        public string Nome = "";
        public double Preco;
        public int Estoque;

        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }
        
        public void ExibirDadosProduto()
        {
            Console.WriteLine($"|{Nome}| preco: {Preco} Em estoque: {Estoque}");
        }
    }
}