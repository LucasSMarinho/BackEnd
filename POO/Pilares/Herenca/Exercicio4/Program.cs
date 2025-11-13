using Exercicio4;

Aluno A1 = new Aluno();
Professor P1 = new Professor();

A1.Nome = "Felipe";
A1.Idade = 17;
A1.Curso = "Desenvolvimento de sistemas";

P1.Nome = "Eduardo";
P1.Idade = 38;
P1.Disciplina = "Desenvolvimento de sistemas";

Console.WriteLine($"Nome: {A1.Nome}");
Console.WriteLine($"Idade: {A1.Idade}");
Console.WriteLine($"Curso: {A1.Curso}");
Console.WriteLine();


Console.WriteLine($"Nome: {P1.Nome}");
Console.WriteLine($"Idade: {P1.Idade}");
Console.WriteLine($"Disciplina: {P1.Disciplina}");
Console.WriteLine();