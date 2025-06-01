using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Example Scripture initialization
        Scripture scripture1 = new Scripture("John 3:16", new List<string>()
        {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        });

        Scripture scripture2;
        try
        {
            using (StreamReader reader = new StreamReader("proverbs_3_5-6.txt"))
            {
                 scripture2 = new Scripture(reader);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: proverbs_3_5-6.txt not found. Please create the file.");
            Console.WriteLine("Example content for proverbs_3_5-6.txt:");
            Console.WriteLine("Proverbs 3:5-6");
            Console.WriteLine("Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
            Console.WriteLine("In all thy ways acknowledge him, and he shall direct thy paths.");
            return; 
        }


        Scripture currentScripture = scripture2; 
        // Scripture currentScripture = scripture1;


        RunScriptureHidingGame(currentScripture);
    }

    public static void RunScriptureHidingGame(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ending.");
    }
}