namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //Cria um construtor na base aluno que recebe o endereço
        //Chama o construtor da base mãe (base) e repassa o endereço para ela
        public Aluno(Endereco endereco) : base(endereco)
        { }


        public string RA = " ";

        public float NotaFinal = 0;

        public string Curso = " ";
    }
}