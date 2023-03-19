//Snack 12
Console.WriteLine("Inserisci un numero");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il numero inserito è {checkEvenOdd(input)}");
string checkEvenOdd(int num)
{
    if (num % 2 == 0)
    {
        return "pari";
    }
    else
    {
        return "dispari";
    }
}