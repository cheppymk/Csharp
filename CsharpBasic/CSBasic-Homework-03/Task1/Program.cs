int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter integer no." + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine("The result is: " + sum);