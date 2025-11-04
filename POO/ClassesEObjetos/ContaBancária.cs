namespace ClassesEObjetos
{
    public class ContaBancária
    {
        //propriedades - atributos
        public String Titular = " ";
        public double Saldo = 0;


        // metodos 

        public void Depositar(double _n)
        {
            Saldo += double.Parse(System.Console.ReadLine());
        }

        public void Sacar(double _n)
        {
            if(Saldo - _n < 0)
            {
                System.Console.WriteLine("Saldo insuficiente");
                return;
            }
            else
            {
                Saldo -= double.Parse(System.Console.ReadLine());
            }
        }
    }
}