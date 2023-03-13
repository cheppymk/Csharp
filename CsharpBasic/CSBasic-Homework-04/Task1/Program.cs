Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

if (input.Length >= 5)
{
    string lastFive = input.Substring(input.Length - 5);
    Console.WriteLine("Last 5 characters: " + lastFive);
}
else
{
    Console.WriteLine("The input string is too short!");
}
