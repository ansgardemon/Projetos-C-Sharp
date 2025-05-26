int posicao;

Console.WriteLine("Digite a posição do atleta: ");
posicao = int.Parse(Console.ReadLine());

switch (posicao)
{
    case 1:
        Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de ouro");
        break;
    case 2:
        Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de prata");
        break;
    case 3:
        Console.WriteLine($"O(a) atleta está na posição {posicao} e recebeu a medalha de bronze");
        break;
    default:
        Console.WriteLine($"O(a) atleta está na posição {posicao} e não se qualificou para nenhuma medalha");
        break;
}

Console.ReadLine();
