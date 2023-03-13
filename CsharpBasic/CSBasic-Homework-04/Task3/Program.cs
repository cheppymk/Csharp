int DigitSum(int number)
{
    int sum = 0;
    string numString = number.ToString();
    foreach (char c in numString) 
    {
        int digit = int.Parse(c.ToString()); 
        sum += digit; 
    }
    return sum;
}

Console.WriteLine(DigitSum(2345));

