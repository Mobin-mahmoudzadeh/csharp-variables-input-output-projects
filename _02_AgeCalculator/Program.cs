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
            const int currentYear = 2026;
            
            // Prompting user for their birth year
            Console.Write("Enter your birth year (e.g.2005)");
            int birthYear = Convert.ToInt32(Console.ReadLine());
        }
    }
}

