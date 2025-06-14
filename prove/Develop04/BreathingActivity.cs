using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        DisplayStartingMessage();
        int timeElapsed = 0;

        while (timeElapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(3);
            Console.Write("Breathe out...");
            ShowCountdown(3);
            timeElapsed += 6;
        }

        DisplayEndingMessage();
    }

    
}