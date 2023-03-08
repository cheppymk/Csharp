// See https://aka.ms/new-console-template for more information
string[] nameArray = new string[100]; 
int index = 0; 

while (true)
{
    Console.Write("Enter a name: ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input)) 
    {
        Console.WriteLine("Invalid input. Please enter a valid name.");
    }
    else
    {
        nameArray[index++] = input.Trim();
    }

    Console.Write("Do you want to enter another name? (Y/N): ");
    string choice = Console.ReadLine();

    if (string.Equals(choice, "N", StringComparison.OrdinalIgnoreCase)) 
    {
        break;
    }
}

Console.WriteLine("The entered names are:");

for (int i = 0; i < index; i++)
{
    Console.WriteLine(nameArray[i]); 
}
