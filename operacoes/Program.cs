int numero1, numero2;
double resultadoSoma, resultadoSub, resultadoDiv, resultadoMult, resultadoMod;


Console.WriteLine("Digite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultadoSoma = numero1 + numero2;
resultadoSub = numero1 - numero2;
resultadoMult = numero1 * numero2;
if (numero1 == 0 || numero2 == 0)
{
    Console.WriteLine("\nA divisão por zero não é permitida.");
    resultadoDiv = 0;
    resultadoMod = 0;
} else
{
    resultadoDiv = (double)numero1 / numero2;
    
    resultadoMod = numero1 % numero2;
}

Console.WriteLine($"== Operações com os números {numero1} e {numero2} ==");

Console.WriteLine("== SOMA ==");
Console.WriteLine($"{resultadoSoma}\n");

Console.WriteLine("== SUBTRAÇÃO ==");
Console.WriteLine($"{resultadoSub}\n");

Console.WriteLine("== DIVISÃO ==");
Console.WriteLine($"{resultadoDiv}\n");

Console.WriteLine("== RESTO DA DIVISÃO ==");
Console.WriteLine($"{resultadoMod}\n");

Console.WriteLine("== MULTIPLICAÇÃO ==");
Console.WriteLine($"{resultadoMult}\n");






