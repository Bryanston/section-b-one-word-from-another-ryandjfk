// Console template
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first word: ");
        string word1 = Console.ReadLine();

        Console.WriteLine("Enter your second word: ");
        string word2 = Console.ReadLine();

        bool canBeMade = true;

        int[] letterCounts = new int[26];

        foreach (char letter in word2)
        {
            int index = letter - 'A';
            letterCounts[index]++;
        }

        foreach (int count in letterCounts)
        {
            Console.Write(count + " ");
        }

        foreach (char letter in word1)
        {
            int index = letter - 'A';

            if (letterCounts[index] == 0)
            {
                canBeMade = false;
            }
            else
            {
                letterCounts[index]--;
            }
        }

        Console.WriteLine();
        foreach (int count in letterCounts)
        {
            Console.Write(count + " ");
        }

        if (canBeMade)
        {
            Console.WriteLine($"{word1} can be made from {word2}");
        }
        else
        {
            Console.WriteLine($"{word1} cannot be made from {word2}");
        }

    } 
}
