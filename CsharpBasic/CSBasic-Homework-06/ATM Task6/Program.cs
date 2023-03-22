using ATM_Task6;

Customer customer1 = new Customer(1234123412341234, 4325, "Bob Bobsky", 650);
Customer customer2 = new Customer(5678567856785678, 1234, "Alice Wonderland", 1200);
bool exitApp = false;
while (!exitApp)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.Write("Please enter your card number:\n> ");
    long cardNumber = Convert.ToInt64(Console.ReadLine().Replace("-", ""));
    Console.Write("Enter Pin:\n> ");
    int pin = Convert.ToInt32(Console.ReadLine());

    Customer customer = null;

    if (customer1.GetCardNumber() == cardNumber)
    {
        customer = customer1;
    }
    else if (customer2.GetCardNumber() == cardNumber)
    {
        customer = customer2;
    }

    if (customer != null && customer.CheckPin(pin))
    {
        Console.WriteLine($"Welcome {customer.GetFullName()}!");
        bool repeat;
        do
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Withdrawal");
            Console.WriteLine("3. Cash Deposit");
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Your balance is {customer.GetBalance()}$.");
                    break;
                case 2:
                    Console.Write("Enter the amount you want to withdraw:\n> ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    customer.Withdraw(amount);
                    Console.WriteLine($"You withdrew {amount}$. You have {customer.GetBalance()}$ left on your account.");
                    break;
                case 3:
                    Console.Write("Enter the amount you want to deposit:\n> ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    customer.Deposit(amount);
                    Console.WriteLine($"You deposited {amount}$. You have {customer.GetBalance()}$ on your account.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            repeat = AskForAnotherAction();
            if (!repeat)
            {
                exitApp = true;
            }
        } while (repeat);
    }
    else
    {
        Console.WriteLine("Invalid card number or PIN. Please try again.");
    }
}
static bool AskForAnotherAction()
{
    Console.WriteLine("Do you want to perform another action? (yes/no)");
    string input = Console.ReadLine().ToLower();

    if (input == "yes" || input == "y")
    {
        return true;
    }

    Console.WriteLine("Thank you for using the ATM app. Goodbye!");
    return false;
}
