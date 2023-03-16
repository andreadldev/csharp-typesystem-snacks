//Snack 2
Console.WriteLine("Inserisci una parola");
string str1 = Console.ReadLine() ?? "";

Console.WriteLine("Inserisci una seconda parola");
string str2 = Console.ReadLine() ?? "";

if (str1.Length > str2.Length)
{
    Console.WriteLine($"La parola più lunga è: {str1}");
    Console.WriteLine($"La parola più corta è: {str2}");
}
else if (str1.Length < str2.Length)
{
    Console.WriteLine($"La parola più lunga è: {str2}");
    Console.WriteLine($"La parola più corta è: {str1}");
}
else
{
    Console.WriteLine("Le due parole hanno la stessa lunghezza");
}