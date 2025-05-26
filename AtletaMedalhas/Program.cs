int posicao;

Console.WriteLine("Digite a posição do atleta: ");
posicao = int.Parse(Console.ReadLine());

if (posicao == 1)
{
    Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de ouro");
} else if (posicao == 2)
{
    Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de prata");
} else if (posicao == 3)
{
    Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de bronze");
} else
{
    Console.WriteLine($"O(a) atleta está na posição {posicao} e não se qualificou para nenhuma medalha");
}



Console.ReadLine();