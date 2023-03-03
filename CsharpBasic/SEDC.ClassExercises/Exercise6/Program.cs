// See https://aka.ms/new-console-template for more information
// take input from the user and parse it into integers
Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());

// compare the two numbers and write the larger one to the console
if (num1 > num2)
{
    Console.WriteLine("The larger number is: " + num1);
}
else if (num2 > num1)
{
    Console.WriteLine("The larger number is: " + num2);
}
else
{
    Console.WriteLine("The two numbers are equal.");
}

// determine if each number is even or odd and write the result to the console
if (num1 % 2 == 0)
{
    Console.WriteLine(num1 + " is even.");
}
else
{
    Console.WriteLine(num1 + " is odd.");
}

if (num2 % 2 == 0)
{
    Console.WriteLine(num2 + " is even.");
}
else
{
    Console.WriteLine(num2 + " is odd.");
}
