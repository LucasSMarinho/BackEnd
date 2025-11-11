namespace TheBasics
{
    public class Carro : Veiculo
    {
        public void AbrirPortaMala()
        {
            Console.WriteLine($"Porta mala aberto");  
        }
        public void FecharPortaMala()
        {
            Console.WriteLine($"Porta mala fechado");  
        }
    }
}