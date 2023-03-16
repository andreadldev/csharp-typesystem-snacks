//Snack 8
int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int sum = 0;

Console.Write("Lista numeri:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]+" ");
}

string numbersToString = String.Join("", Array.ConvertAll(numbers, x => x.ToString()));
Console.Write("\nNumeri in posizione dispari: ");
for (int i = 0; i < numbersToString.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        Console.Write(numbers[i] + " ");
        sum += numbers[i];
    }
}
Console.WriteLine($"\nSomma dei numeri in posizione dispari: {sum}");