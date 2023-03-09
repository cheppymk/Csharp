decimal balance = 500.0m; 

while (true) 
{
    Console.WriteLine("Welcome to the ATM!");
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Withdraw money");
    Console.WriteLine("3. Quit");

    string input = Console.ReadLine();

    if (input == "1") 
    {
        Console.WriteLine($"You have ${balance} on your account.");
    }
    else if (input == "2") 
    {
        Console.WriteLine("Please enter the amount of money you want to withdraw:");
        string amountString = Console.ReadLine();

        if (decimal.TryParse(amountString, out decimal amount)) 
        {
            if (amount > balance)
            {
                Console.WriteLine($"You cannot withdraw ${amount} because your balance is ${balance}. Please try again with appropriate amount!");
            }
            else
            {
                balance -= amount; 
                Console.WriteLine($"You have successfully withdrawn ${amount} and you have ${balance} left on your account.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid amount.");
        }
    }
    else if (input == "3") 
    {
        Console.WriteLine("Thank you for using our ATM. Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid option.");
    }


    Console.WriteLine("Do you want to take some other action? (Y/N)");
    string answer = Console.ReadLine();

    if (answer.ToUpper() != "Y") 
        Console.WriteLine("Thank you for using our ATM. Goodbye!");
        break;
    }

