using System;

public class Main
{
    public static void Main()
    {
        // Get the current date and time
        System.DateTime today = System.DateTime.Now;

        // Display the current date and time
        System.Console.WriteLine("Today = " + System.DateTime.Now);

        // Define a TimeSpan representing a duration of 40 days
        System.TimeSpan duration = new System.TimeSpan(40, 0, 0, 0);

        // Add the defined duration (40 days) to the current date
        System.DateTime answer = today.Add(duration);

        // Display the day of the week for the resulting date
        System.Console.WriteLine("{0:dddd}", answer);
    }
}
