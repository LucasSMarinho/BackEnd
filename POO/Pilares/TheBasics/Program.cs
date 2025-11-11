using TheBasics;



Carro Mustang = new Carro();
Mustang.marca = "Ford";
Mustang.modelo = "Dark Horse";
Mustang.QtdRodas = 4;
Mustang.Ligar();
Mustang.AbrirPortaMala();  


Moto Yamaha = new Moto();
Yamaha.marca = "Yamaha";
Yamaha.modelo = "WR450F ";
Yamaha.QtdRodas = 2;
Yamaha.Ligar();
Yamaha.Empinar();


Aviao BetterCallSaul = new Aviao();
BetterCallSaul.marca = "Wayfarer";
BetterCallSaul.modelo = "Boeing 737";
BetterCallSaul.QtdRodas = 6;
BetterCallSaul.LevantarVoo();
BetterCallSaul.Pousar();









// Console.Clear();

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Espirola Peixera";
// endEnzo.Numero = 3890;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;




// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua Carvalho";
// endAlexia.Numero = 137;
// Professor profAlexia = new Professor(endEnzo);
// profAlexia.Salario = 7800.75f;
// profAlexia.Nome = "Aléxia Vitória";


// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} do(a) prof. {profAlexia}");





// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niterói";


// Endereco enderecoPhil = new Endereco();
// enderecoPhil.Logradouro = "Rua Dali";


// Endereco enderecoHen = new Endereco();
// enderecoHen.Logradouro = "Rua Praca";


// Endereco enderecoElo = new Endereco();
// enderecoElo.Logradouro = "Rua Dela";


// Pessoa eduardo = new Pessoa(enderecoEdu);
// Pessoa philip = new Pessoa(enderecoPhil);
// Pessoa henrique = new Pessoa(enderecoHen);
// Pessoa eloysa = new Pessoa(enderecoElo);

// eduardo.Nome = "Eduardo";
// eduardo.Idade = 43;

// philip.Nome = "Felipe";
// philip.Idade = 17;

// henrique.Nome = "Henrique";
// henrique.Idade = 17;

// eloysa.Nome = "Eloysa";
// eloysa.Idade = 17;

// peoples.Add(eduardo);
// peoples.Add(philip);
// peoples.Add(henrique);
// peoples.Add(eloysa);

// //For each

// foreach (var Pessoa in peoples)
// {
//     Console.WriteLine($"--------------------");
//     Console.WriteLine($"Nome: {Pessoa.Nome}");
//     Console.WriteLine($"Idade: {Pessoa.Idade}");
//     Console.WriteLine($"--------------------");
// }



// string[] nomes = { "Eduardo", "Lucas" };

// Console.WriteLine($"Quantidades de pessoas da lista: {peoples.Count}");
// Console.WriteLine($"Qantidade de pessoas do array: {nomes.Length}");