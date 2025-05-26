



Console.WriteLine("Digite um número inteiro:");
int numero = int.Parse(Console.ReadLine());



// Negativo, nulo ou positivo
if (numero < 0)
{
    Console.WriteLine("O número é negativo!");
    Console.ReadLine();
}
else if (numero == 0)
{
    Console.WriteLine("O número é nulo!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("O número é positivo!");
    Console.ReadLine();
}

