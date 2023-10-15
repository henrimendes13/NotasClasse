using NotasClasse;

Aluno aluno =  new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine());
aluno.Nota2 = double.Parse(Console.ReadLine());
aluno.Nota3 = double.Parse(Console.ReadLine());

Console.Write("NOTA FINAL = ");
Console.WriteLine(aluno.NotaFinal());

Console.WriteLine(aluno);


