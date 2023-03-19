//Snack 10
while (true)
{
    Console.WriteLine("Inserisci un numero di array da generare");
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }

        Console.WriteLine('\n');
        continue;
    }
}