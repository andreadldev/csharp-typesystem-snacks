//Snack 4
int[] numbers = new int[10];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i == 0 || i == 1)
    {
        Console.WriteLine($"Inserisci un numero (ciclo {i + 1})");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    else {
        Console.WriteLine($"Inserisci un numero (ciclo {i + 1})");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum += numbers[i];
    }
}
Console.WriteLine($"La somma dei numeri inseriti dopo il secondo è {sum}");
Console.WriteLine($"La media dei numeri inseriti dopo il secondo è {sum / 8}");