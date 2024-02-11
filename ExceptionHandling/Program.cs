//Write a C# program that prompts the user to input a numeric integer and throws
//an exception if the number is less than 0 or greater than 1000.
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt user to input a numeric integer and read the input
            Console.Write("Input a numeric integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            ValidateNumberRange(number);

            
            Console.WriteLine("Valid input: " + number);
        }
        catch (NumberOutOfRangeException ex)
        {
            // Catch block for handling NumberOutOfRangeException
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException) { 
            Console.WriteLine("Error: Invalid input. Please enter a numeric integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Method to validate if the number is within the specified range
    static void ValidateNumberRange(int number)
    {
        if (number < 0 || number > 1000)
        {
            // Throw NumberOutOfRangeException if the number is out of the specified range
            throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 1000.");
        }
    }
}

// Custom exception class for NumberOutOfRangeException
class NumberOutOfRangeException : Exception
{
    public NumberOutOfRangeException(string message) : base(message) { }
}
