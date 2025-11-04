namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public int QtdRodas = 0;
        public string Marca = "";
        public string Modelo = "";
        public string Cor = "";

        //metodos 
        public void Ligar()
        {
            Console.WriteLine($"Moto ligando");
        }

        public void Desligar()
        {
            Console.WriteLine($"Moto desligando");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Moto acelerando");
        }

        public void Freiar()
        {
            Console.WriteLine($"Moto freiando");
        }
    }
}