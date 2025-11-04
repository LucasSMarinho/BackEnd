namespace ClassesEObjetos
{
    public class Garrafa
    {
        public double VolumeLitros = 0;
        public string Cor = "";
        public string Marca = "";
        public string Material = "";

        public void Encher()
        {
            Console.WriteLine($"Garrafa enchendo");
        }
                public void Esvaziando()
        {
            Console.WriteLine($"Garrafa esvaziando");
        }


    }
}