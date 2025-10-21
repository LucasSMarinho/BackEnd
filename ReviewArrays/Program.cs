// See https://aka.ms/new-console-template for more information
string nome = "Eduardo";
Console.WriteLine($"Nome: {nome}");

string[] nomes = new string[4];

nomes[0] = "Maria";
nomes[1] = "Anna";
nomes[2] = "Felipe";
nomes[3] = "Hugo";

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
Console.WriteLine(nomes[i]);  
}
