using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class ProdutoComDesconto
    {
        public string Nome = " ";
        public double Preco = 0;

        public double AplicarDesconto(Double Percentual)
        {
            return (Percentual / 100) * Preco;
        }
    }
}