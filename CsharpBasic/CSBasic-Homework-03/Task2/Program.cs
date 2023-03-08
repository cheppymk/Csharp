string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Ana", "Maja", "Ivan", "Dario", "Jana" };

Console.Write("Enter student group: ");
if (int.TryParse(Console.ReadLine(), out int group) && group >= 1 && group <= 2)
{
    string[] students = group == 1 ? studentsG1 : studentsG2;

    Console.WriteLine("The Students in G" + group + " are:");
    foreach (string student in students)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 2.");
}
