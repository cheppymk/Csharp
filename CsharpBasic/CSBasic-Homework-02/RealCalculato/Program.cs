// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number: ");
double firstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number: ");
double secondNum = double.Parse(Console.ReadLine());    

Console.WriteLine("Enter the Operation (+,-,*,/): ");
char operation = char.Parse(Console.ReadLine());

double result = 0.0;

switch (operation)
{
case '+':
    result = firstNum + secondNum;
    break;
case '-':
    result = secondNum - firstNum;
    break;
case '*':
    result = firstNum * secondNum;
    break;
case '/':
    result = secondNum / secondNum;
    break;
default:
    Console.WriteLine("Invalid operation!");
    break;
}

Console.WriteLine("The result is: " + result);