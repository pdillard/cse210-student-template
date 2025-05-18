using System.Collections.Generic;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    Prompts promptGen = new Prompts();
    bool running = true;

    while (running)
    {
      Console.WriteLine("Menu");
      Console.WriteLine("1. Write a new entry");
      Console.WriteLine("2. Display journal entries");
      Console.WriteLine("3. Save journal to file");
      Console.WriteLine("4. Load journal from file");
      Console.WriteLine("5. Quit");

      Console.Write("Choose an option: ");
      string userInput = Console.ReadLine();

      switch (userInput)
      {
        case "1":
          string prompt = promptGen.GetRandomPrompt();
          Console.WriteLine($"\nPrompt: {prompt}");
          Console.Write("Your entry: ");
          string response = Console.ReadLine();
          Entry entry = new Entry(DateTime.Now, prompt, response);
          journal.addEntry(entry);
          break;

        case "2":
          journal.DisplayEntries();
          break;

        case "3":
          Console.Write("Enter filename to save: ");
          string saveFile = Console.ReadLine();
          journal.SaveToFile(saveFile);
          break;

        case "4":
          Console.Write("Enter filename to load: ");
          string loadFile = Console.ReadLine();
          journal.LoadFromFile(loadFile);
          break;

        case "5":
          running = false;
          break;

        default:
          Console.WriteLine("Invalid Option");
          break;   
      }
    }   
  }
}
