using System;

public class Program
{

    public static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("Helaman 5:12", new List<string>()
        {

        });

        using (StreamReader reader = new StreamReader("proverbs_3_5-6.txt"))
        {
             Scripture scripture2 = new Scripture(reader);
        }
    }
}