//Snack 7
int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Inserisci un numero (ciclo {i + 1})");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] % 2 != 0)
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"La somma dei numeri dispari inseriti è {sum}");