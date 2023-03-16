//Snack 1
Console.WriteLine("Inserisci un numero");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci un secondo numero");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Il numero più grande è {num1}");
}
else
{
    Console.WriteLine($"Il numero più grande è {num2}");
}