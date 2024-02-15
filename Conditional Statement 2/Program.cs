using System;  

public class Exercise2
{
    public static void Main()  
    {
        float PerHeight;  
        Console.Write("\n\n"); 
        Console.Write("Accept the height of a person in centimeter and categorize them:\n");  
        Console.Write("----------------------------------------------------------------"); 
        Console.Write("\n\n");  

        Console.Write("Input the height of the person (in centimetres):"); 
        PerHeight = Convert.ToInt32(Console.ReadLine());  

        if (PerHeight < 150.0)  // Checking if the height is less than 150 centimeters
            Console.Write("The person is Dwarf. \n\n");  // Printing a message if the person is categorized as a dwarf
        else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))  // Checking if the height is between 150 and 165 centimeters
            Console.Write("The person is average heighted. \n\n");  // Printing a message if the person is categorized as average heighted
        else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))  // Checking if the height is between 165 and 195 centimeters
            Console.Write("The person is taller. \n\n");  // Printing a message if the person is categorized as taller
        else
            Console.Write("Abnormal height.\n\n");  
    }
}
