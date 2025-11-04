namespace PrimeiraClasse
{
    public class Hello
    {

    // Propriedades - Características
    public string TextoHello = "";

        // Métodos
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
    public void SaldarComNome(string nome)
    {
        Console.WriteLine($"Olá, {nome}");
    }
}
}
