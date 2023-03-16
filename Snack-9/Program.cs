//Snack 9
var numbers = new List<int>();
int sum = 0;
int digit = 0;

while (sum < 50)
{
    Console.WriteLine("Inserisci un numero da 1 a 10");
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < 1 || num > 10)
    {
        Console.WriteLine("Input non valido. Il numero deve essere compreso tra 1 e 10");
        num = Convert.ToInt32(Console.ReadLine());
    }
    numbers.Add(num);

    foreach (var number in numbers)
    {
        digit = number;
    }
    sum += digit;
    Console.WriteLine($"Somma numeri nella lista: {sum}");
}

if( sum == 50)
{
    Console.WriteLine("Hai raggiunto 50");
}
else
{
    Console.WriteLine("Hai superato 50");
}
