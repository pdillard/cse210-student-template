using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> number_list = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int x = 0;

        while (x < 1)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int numbers = int.Parse(input);

                if (numbers == 0)
                {
                    x++;
                }

                number_list.Add(numbers);
            }
                 
        int sum = number_list.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double avg = sum / (number_list.Count -1);
        Console.WriteLine($"The average is: {avg}");
        int max = number_list.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}