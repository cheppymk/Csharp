// See https://aka.ms/new-console-template for more information
int[] inputArray = new int[5];
int sum = 0;

Console.WriteLine("Enter five integers:");

for (int i = 0; i < inputArray.Length; i++)
{
    if (int.TryParse(Console.ReadLine(), out int input))
    {
        inputArray[i] = input;
        sum += input;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        i--;
    }
}

Console.WriteLine("The sum of the integers is: " + sum);