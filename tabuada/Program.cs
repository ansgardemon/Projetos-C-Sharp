int numero, i;

Console.WriteLine("Digite um número: ");
numero = int.Parse(Console.ReadLine());


Console.WriteLine($"== TABUADA DO {numero} ==");

for (i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

