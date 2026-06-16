using System;

namespace _02_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- STEP 1: Define Constants & Get Input ---
            Console.WriteLine("=== Age Calculator ===");
            
            // Defining the current year as a constant
            const int CurrentYear = 2026;
            
            // Prompting user for their birth year
            Console.Write("Enter your birth year (e.g.2005)");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            
            // --- STEP 2: Calculate Age & Display Output ---
            // Calculating the age
            int age = CurrentYear - birthYear;

            // Displaying the result using string interpolation
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine($"In the year {CurrentYear}, you are {age} years old.");
            Console.WriteLine("---------------------------------");

            // Keep the console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

