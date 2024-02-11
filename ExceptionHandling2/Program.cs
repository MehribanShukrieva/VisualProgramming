//Write a C# program that creates a method that takes a string as input and converts it to
//uppercase. Handle the NullReferenceException that occurs if the input string is null.
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user to input a string
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

           
            string result = ConvertToUppercase(input);
            Console.WriteLine("Uppercase string: " + result);
        }
        catch (NullReferenceException)
        {
            // Catch block for handling NullReferenceException (null input)
            Console.WriteLine("Error: Input string is null.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Method to convert a string to uppercase
    static string ConvertToUppercase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            // Throw an ArgumentException if the input is null or empty
            throw new ArgumentException("Input string is null or empty.");
        }

        return input.ToUpper();
    }
}
