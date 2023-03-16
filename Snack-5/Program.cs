//Snack 5
Console.WriteLine("Inserisci un numero");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} è pari");
}
else
{
    Console.WriteLine($"{num} è dispari. Il numero successivo è {num + 1}");
}
