using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);


        int x = 0;

        while (x < 1)
            {
                Console.Write("What is your guess? ");
                string guess_string = Console.ReadLine();
                int guess_number = int.Parse(guess_string);

                if (guess_number == magic_number)
                    {
                        Console.WriteLine("You Guessed It!");
                        x++;
                    }
                else if (guess_number > magic_number)
                    {
                        Console.WriteLine("To High!");
                    }
                else if (guess_number < magic_number)
                    {
                        Console.WriteLine("To Low!");
                    }
                    
            }




    }
}