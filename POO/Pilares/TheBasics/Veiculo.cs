namespace TheBasics
{
    public class Veiculo
    {
        public int QtdRodas;
        public string marca = "";
        public string modelo = "";
        
        //metodos

        public void Ligar()
        {
            Console.WriteLine($"Ligando o veiculo");  
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando o veiculo");  
        }
    }
}