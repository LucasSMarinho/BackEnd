//Namespace pode ser considerado como pasta de projeto
//Namespace é o módulo do sistema
//Namespace é com um pacote

using System.Security.Cryptography.X509Certificates;

namespace TheBasics
{
    public class Pessoa
    {
        public string Nome = " ";
        public int Idade = 0;

        public Endereco EnderecoCompleto;

        //Metodos

        public Pessoa (Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }
        public void Falar()
        {
            System.Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }
        public void Envelhecer()
        {
            Idade++;
        }
    }
}