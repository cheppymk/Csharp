// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number from 1 to 3:");

string input = Console.ReadLine(); 


switch (input)
{
    case "1":
        Console.WriteLine("You got a new car!");
        break;
    case "2":
        Console.WriteLine("You got a new plane!");
        break;
    case "3":
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Error: Please enter a number from 1 to 3.");
        break;
}