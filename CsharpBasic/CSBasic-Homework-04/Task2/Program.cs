﻿Console.WriteLine("Enter a sentence:");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

foreach (string word in words)
{
    Console.WriteLine(word);
}

