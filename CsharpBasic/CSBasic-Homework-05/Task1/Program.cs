
using Task1;

Human human = new Human();


Console.Write("Please enter your first name: ");
human.FirstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
human.LastName = Console.ReadLine();

Console.Write("Please enter your age: ");
human.Age = int.Parse(Console.ReadLine());


string details = human.GetPersonDetails();
Console.WriteLine(details);
