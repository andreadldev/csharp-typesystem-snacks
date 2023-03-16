//Snack 6
string[] guestList = {"Paolo", "Giuseppe", "Francesco", "Salvatore", "Michele"};

Console.WriteLine("Inserisci il tuo nome");
string name = Console.ReadLine() ?? "";

for (int i = 0; i < guestList.Length; i++)
{
    if (guestList[i].IndexOf(name, 0, StringComparison.OrdinalIgnoreCase) != -1)
    {
        Console.WriteLine($"Ciao {char.ToUpper(name[0]) + name.Substring(1).ToLower()}, il tuo nome è nella lista degli invitati");
        break;
    }
    else
    {
        if (i == guestList.Length -1)
        {
            Console.WriteLine($"Il tuo nome non è nella lista degli invitati");
        }
    }
}