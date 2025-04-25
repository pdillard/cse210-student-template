using System;

class Program
{
    static void Main(string[] args)
    {
      
      // Prompt the User for First Name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

      // Prompt the User for Last Name  
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    }
}