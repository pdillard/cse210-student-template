using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou completed {_duration} seconds of the {_name}.\n");
        ShowSpinner(2);
    }

    protected void ShowSpinner(int seconds)
    {
    string[] spinner = { "|", "/", "-", "\\" };
    int spinIndex = 0;
    DateTime end = DateTime.Now.AddSeconds(seconds);

    while (DateTime.Now < end)
    {
        Console.Write(spinner[spinIndex]);
        Thread.Sleep(250); 
        Console.Write("\b \b"); 
        spinIndex = (spinIndex + 1) % spinner.Length;
    }
    }

    protected void ShowCountdown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
    }
    Console.WriteLine();
}
        public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}