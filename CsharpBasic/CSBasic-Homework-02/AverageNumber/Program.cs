// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter the First number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Third Number: ");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Fourth Number: ");
int fourthNumber = int.Parse(Console.ReadLine());

int averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

Console.WriteLine("The average of the four numbers is "+ averageNumber);