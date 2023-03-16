//Snack 3
int[] numbers = new int[10];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Inserisci un numero (ciclo {i})");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    sum += numbers[i];
}
Console.WriteLine($"La somma dei numeri inseriti è {sum}");