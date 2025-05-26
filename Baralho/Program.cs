int carta1 = 0, carta2 = 0;
bool entradaValida1 = false;
bool entradaValida2 = false;


while (entradaValida1 == false) { 
Console.WriteLine("Digite um valor de carta entre 1 e 13 para a primeira carta: ");
carta1 = int.Parse(Console.ReadLine());

if (carta1 >=1 && carta1 <= 13)
{
        entradaValida1 = true;
} else { Console.WriteLine("Número inválido. Digite um número entre 1 e 13."); }


}

while (entradaValida2 == false)
{
    Console.WriteLine("Digite um valor de carta entre 1 e 13 para a segunda carta: ");
    carta2 = int.Parse(Console.ReadLine());

    if (carta2 >= 1 && carta2 <= 13)
    {
        entradaValida2 = true;
    }
    else { Console.WriteLine("Número inválido. Digite um número entre 1 e 13."); }


}


if (carta1 == carta2)
{
    Console.WriteLine($"As cartas são iguais: {carta1}");
}
else if (carta1 > carta2)
{
    Console.WriteLine($"A primeira carta ({carta1}) é maior que a segunda ({carta2})");
}
else
{
    Console.WriteLine($"A segunda carta ({carta2}) é maior que a primeira ({carta1})");
}
