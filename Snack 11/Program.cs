//Snack 11
Console.WriteLine("Inserisci una parola");
string input1 = Console.ReadLine() ?? "";

Console.WriteLine("Inserisci una seconda parola");
string input2 = Console.ReadLine() ?? "";

Console.WriteLine(checkStrLength(input1, input2));

string checkStrLength(string str1, string str2) 
{
	if (str1.Length > str2.Length)
	{
		return str1;
	}
	else if (str1.Length < str2.Length)
	{
		return str2;
	}
	else
	{
		string output = $"{str1}, {str2}";
		return output;
	}
}