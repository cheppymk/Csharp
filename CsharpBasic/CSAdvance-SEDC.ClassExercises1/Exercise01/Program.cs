

using Exercise01.Models;
using Newtonsoft.Json;

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dogs.json");

while (true)
{
    Console.WriteLine("Enter dog name (type 'exit' to stop):");
    string name = Console.ReadLine();

    if (name.ToLower() == "exit")
    {
        break;
    }

    Console.WriteLine("Enter dog age:");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter dog color:");
    string color = Console.ReadLine();

    Dog newDog = new Dog { Name = name, Age = age, Color = color };

    SaveDogToFile(newDog, filePath);
}

PrintAllDogs(filePath);
    

    static void SaveDogToFile(Dog dog, string filePath)
{
    List<Dog> dogs;

    if (File.Exists(filePath))
    {
        string existingJson = File.ReadAllText(filePath);
        dogs = JsonConvert.DeserializeObject<List<Dog>>(existingJson) ?? new List<Dog>();
    }
    else
    {
        dogs = new List<Dog>();
    }

    dogs.Add(dog);

    string json = JsonConvert.SerializeObject(dogs, Formatting.Indented);
    File.WriteAllText(filePath, json);
}

static void PrintAllDogs(string filePath)
{
    if (File.Exists(filePath))
    {
        string json = File.ReadAllText(filePath);
        List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(json);

        Console.WriteLine("Dogs:");
        foreach (Dog dog in dogs)
        {
            Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
        }
    }
    else
    {
        Console.WriteLine("No dogs found in file.");
    }
}
