Console.WriteLine("Enter your birthday in the format of MM/DD/YYYY:");
DateTime birthday = DateTime.Parse(Console.ReadLine());

static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;
    if (birthday > today.AddYears(-age))
    {
        age--;
    }
    return age;
}

int age = AgeCalculator(birthday);

Console.WriteLine($"Your age is {age}");