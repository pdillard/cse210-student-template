using System;

class Program
{
    static void Main(string[] args)
    {

        bool running = true;
        while (running != true)

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 5) {
                running = false;
            }
            else if (userInput == 1) {
                // writeJournalEntry()
                return;
            }
            else if (userInput == 2) {
                // displayJournalEntry()
                return;
            }
            else if (userInput == 3) {
                // loadJournal()
                return;
            }
            else if (userInput == 4) {
                // saveJournal()
                return;
            }
            else {
                Console.WriteLine("Invalid input");
            }



        


    }
}