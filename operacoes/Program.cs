int numero1, numero2;
double resultadoSoma, resultadoSub, resultadoDiv, resultadoMult;


Console.WriteLine("Digite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultadoSoma = numero1 + numero2;
resultadoSub = numero1 - numero2;
resultadoDiv = (double)numero1 / numero2;
resultadoMult = numero1 * numero2;



Console.WriteLine($"== Operações com os números {numero1} e {numero2} ==");

Console.WriteLine("== SOMA ==");
Console.WriteLine($"{resultadoSoma}\n");

Console.WriteLine("== SUBTRAÇÃO ==");
Console.WriteLine($"{resultadoSub}\n");

Console.WriteLine("== DIVISÃO ==");
Console.WriteLine($"{resultadoDiv}\n");

Console.WriteLine("== MULTIPLICAÇÃO ==");
Console.WriteLine($"{resultadoMult}\n");




