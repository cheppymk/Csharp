// See https://aka.ms/new-console-template for more information
int n = 8; 
int m = 5; 
int branches = 12; 
int totalApples = n * branches; 
int basketsNeeded = totalApples / m; 
int remainder = totalApples % m; 

if (remainder > 0)
{
    basketsNeeded += 1; 
}

Console.WriteLine("Total apples: " + totalApples);
Console.WriteLine("Baskets needed: " + basketsNeeded);
