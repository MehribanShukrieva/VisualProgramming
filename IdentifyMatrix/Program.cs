using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input a number:");

            n = Convert.ToInt32(Console.ReadLine());

            // Create a square matrix of size n x n filled with zeroes except for diagonal elements (identity matrix)
            var M =
                Enumerable.Range(0, n)
                    .Select(i =>
                        Enumerable.Repeat(0, n)
                            .Select((z, j) => j == i ? 1 : 0) // Sets diagonal elements to 1, rest to 0
                            .ToList()
                    )
                    .ToList();

            // Display the matrix (identity matrix) generated above
            foreach (var row in M)
            {
                foreach (var element in row)
                {
                    Console.Write(" " + element); // Print each element of the matrix row
                }
                Console.WriteLine(); // Move to the next line after printing each row
            }
        }
    }
}
