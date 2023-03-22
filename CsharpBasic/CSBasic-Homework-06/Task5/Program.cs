using Task5;

User[] users = new User[]
{
    new User(1, "Alice", "password123", new string[] { "Hello!", "How are you?" }),
    new User(2, "Bob", "qwerty", new string[] { "Hey there!", "I'm good, thanks!" }),
    new User(3, "Charlie", "supersecure", new string[] { "Hi everyone!", "What's up?" }),
};

bool exit = false;

while (!exit)
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Log in");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");
    Console.Write("Enter the number of your choice: ");

    int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        LogIn(users);
        break;
    case 2:
        Register(users);
        break;
    case 3:
        exit = true;
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
}
}

static void LogIn(User[] users)
{
    Console.Write("Enter your username: ");
    string username = Console.ReadLine();
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    User foundUser = null;
    for (int i = 0; i < users.Length; i++)
    {
        if (users[i].Username == username && users[i].Password == password)
        {
            foundUser = users[i];
            break;
        }
    }

    if (foundUser != null)
    {
        Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");
        for (int i = 0; i < foundUser.Messages.Length; i++)
        {
            Console.WriteLine(foundUser.Messages[i]);
        }
    }
    else
    {
        Console.WriteLine("Error: Invalid username or password.");
    }
}

static void Register(User[] users)
{
    Console.Write("Enter your ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter your username: ");
    string username = Console.ReadLine();
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    bool usernameExists = false;
    for (int i = 0; i < users.Length; i++)
    {
        if (users[i].Username == username)
        {
            usernameExists = true;
            break;
        }
    }

    if (!usernameExists)
    {
        User newUser = new User(id, username, password, new string[0]);
        User[] newUsers = new User[users.Length + 1];
        for (int i = 0; i < users.Length; i++)
        {
            newUsers[i] = users[i];
        }

        newUsers[newUsers.Length - 1] = newUser;
        users = newUsers;

        Console.WriteLine("Registration complete! Users:");
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"{users[i].Id} {users[i].Username}");
        }
    }
    else
    {
        Console.WriteLine($"There is already a user with the username '{username}'");
    }
}
    