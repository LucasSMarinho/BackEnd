namespace Encapsulamento
{
    public class Carro
    {
        private string Marca = " ";
        private string Modelo = " ";
        private int VelocidadeAtual = 0;
        private int VelocidadeMaxima = 372;


        public void DefinirMarca(String marca)
        {
         Marca = marca;
        }
        public void ObterMarca()
        {
         Console.WriteLine($"Marca do carro: {Marca}");
        }
        public void DefinirModelo(String modelo)
        {
         Modelo = modelo;
        }
        public void ObterModelo()
        {
         Console.WriteLine($"Modelo do carro: {Modelo}");
        }

        public void DefinirVelocidade(int velocidadeAtual)
        {
         VelocidadeAtual = velocidadeAtual;
        }

        public void ObterVelocidade()
        {
         Console.WriteLine($"Velocidade do carro: {VelocidadeAtual}");
        }

        public void Acelerar(int a)
        {
            if((VelocidadeAtual + a) <= VelocidadeMaxima)
            {
                VelocidadeAtual += a;
            }
        }
        public void Freiar(int f)
        {
            if((VelocidadeAtual - f) >= 0)
            {
                VelocidadeAtual -= f;
            }
        }
    }
}