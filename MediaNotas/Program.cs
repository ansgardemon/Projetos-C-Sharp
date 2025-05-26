
double media = 0;
double soma = 0;
string resultado;

Console.WriteLine("Digite a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

soma = soma + nota1;

Console.WriteLine("Digite a segunda nota");
double nota2 = double.Parse(Console.ReadLine());

soma = soma + nota2;

Console.WriteLine("Digite a terceira nota");
double nota3 = double.Parse(Console.ReadLine());

soma = soma + nota3;


media = (soma / 3);


if (media >= 7)
{

    resultado = "Aprovado";

}
else if (media >= 5)
{
    resultado = "de recuperação";
}
else
{
    resultado = "Reprovado";
}




Console.WriteLine($"A média do(a) aluno(a) é {media.ToString("F")} e está {resultado}");

