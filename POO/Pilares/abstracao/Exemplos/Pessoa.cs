namespace Exemplos
{
    public abstract class Pessoa : Animal
    {
         public override void FazerSom()
        {
            Console.WriteLine("Bingo");
        }
        public override void Mover()
        {
            Console.WriteLine("Plec, plec");
        }
    }
}