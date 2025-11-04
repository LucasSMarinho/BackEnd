using MetodoConstrutor;

Pessoa fontes = new Pessoa("João", 17);

fontes.ExibirDados();

//primeira pessoa

Pessoa3Sobrecarga SegundaPessoa = new Pessoa3Sobrecarga("Matheus Felix");
Console.WriteLine($"Segunda Pessoa cadastrada");
Console.WriteLine($"Nome: {SegundaPessoa.Nome}");
Console.WriteLine($"Idade: {SegundaPessoa.Idade}");

Pessoa3Sobrecarga TeceiraPessoa = new Pessoa3Sobrecarga();
Console.WriteLine($"Qual o nome da terceira pessoa?");
TeceiraPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Qual a idade da terceira pessoa?");
TeceiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Terceira Pessoa cadastrada");
Console.WriteLine($"Nome: {TeceiraPessoa.Nome}");
Console.WriteLine($"Idade: {TeceiraPessoa.Idade}");