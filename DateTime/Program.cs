using System;

public class Example10
{
    // Main method, entry point of the program
    public static void Main()
    {
        // Get the current date and time
        DateTime today = DateTime.Now;

        // Calculate the date 40 days from the current date using AddDays method
        DateTime answer = today.AddDays(40);

        // Display the current day of the week
        Console.WriteLine("Today: {0:dddd}", today);

        // Display the day of the week 40 days from today
        Console.WriteLine("40 days from today: {0:dddd}", answer);
    }
}
