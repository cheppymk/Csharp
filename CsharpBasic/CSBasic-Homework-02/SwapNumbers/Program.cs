// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the First Number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Second Number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Before Swapping:");
Console.WriteLine("First Number: " + firstNum);
Console.WriteLine("Second Number: " + secondNum);


firstNum = firstNum + secondNum;
secondNum = firstNum - secondNum;
firstNum = firstNum - secondNum;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNum);
Console.WriteLine("Second Number: " + secondNum);


