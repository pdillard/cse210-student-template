using System;

class Program
{
    static void Main(string[] args)
    {
        

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name = Console.ReadLine();
            return user_name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int user_number = int.Parse(input);
            return user_number;
        }

        static int SquareNumber(int user_number)
        {
            int square_number = user_number * user_number;
            return square_number;
        }

        static void DisplayResult(string user_name, int square_number )
        {
            Console.WriteLine($"{user_name}, the square of your number is {square_number}.");
        }
    
}