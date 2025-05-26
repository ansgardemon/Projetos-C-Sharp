
Console.WriteLine("Digite uma nota");

double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine($"A nota do aluno é {nota} e o aluno está Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine($"A nota do aluno é {nota} e o aluno está de Recuperação");
}
else
{
    Console.WriteLine($"A nota do aluno é {nota} e o aluno está Reprovado");
}
