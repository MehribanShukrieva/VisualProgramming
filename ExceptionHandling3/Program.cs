//Write a C# program that reads a number from the user and calculates its square root.
//  Handle the exception if the number is negative.
using System;

class Program
{
    static void Main()
    {
        try
        {
           
            Console.Write("Input a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            // Check if the input number is non-negative
            if (number >= 0)
            {
                // Calculate the square root if the number is non-negative
                double squareRoot = CalculateSquareRoot(number);
                Console.WriteLine("Square root: " + squareRoot);
            }
            else
            {
                // Throw an ArgumentException if the number is negative
                throw new ArgumentException("Number cannot be negative!");
            }
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Error: Invalid input. Please input a valid number.");
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

    
    static double CalculateSquareRoot(double number)
    {
      
        return Math.Sqrt(number);
    }
}
