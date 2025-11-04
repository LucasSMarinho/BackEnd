namespace PrimeiraClasse
{
    public class Carro
    {
        //propriedades
        public int QtdRodas = 0;
        public int QtdPortas = 0;
        public string Marca = "";
        public string Modelo = "";
        public string Cor = "";

        //metodos 
        public void Ligar()
        {
            Console.WriteLine($"Carro ligando");
        }

        public void Desligar()
        {
            Console.WriteLine($"Carro desligando");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando");
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando");
        }
    }
}