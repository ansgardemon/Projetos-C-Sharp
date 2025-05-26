int filho1, filho2, monica = 0;

Console.WriteLine("Digite a idade do primeiro filho: ");
filho1 = int.Parse(Console.ReadLine());

monica += filho1;

Console.WriteLine("Digite a idade do segundo filho");
filho2 = int.Parse(Console.ReadLine());

monica += filho2 + 1;


Console.WriteLine($"A idade da Monica é {monica}");

