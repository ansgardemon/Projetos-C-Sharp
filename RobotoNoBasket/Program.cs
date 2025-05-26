int robot1, robot2;

Console.WriteLine("Digite a pontuação do Robô 1: ");
robot1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a pontuação do Robô 2: ");
robot2 = int.Parse(Console.ReadLine());



if (robot1 == robot2)
{
    Console.WriteLine($"Os robôs empataram com {robot1} pontos cada");
}
else if (robot1 > robot2)
{
    Console.WriteLine($"O Robô 1 venceu com {robot1} pontos contra {robot2} pontos do Robô 2");
}
else
{
    Console.WriteLine($"O Robô 2 venceu com {robot2} pontos contra {robot1} pontos do Robô 1");
}



