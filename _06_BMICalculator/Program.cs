using System;

namespace _06_Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Body Mass Index (BMI) Calculator");
            Console.WriteLine("----------------------------------------");
            
            // --- STEP 1: Get Inputs ---
            Console.Write("Enter weight in kilograms (e.g., 1.75): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter height in meters (e.g., 1.75): ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 2: Calculate BMI ---
            // Formula: weight / (height * height)
            double bmi = weight / (height * height);
            
            // --- STEP 3: Display Result ---
            Console.WriteLine("\n------------------- Result -------------------");
            Console.WriteLine($"Weight: {weight} kg | Height: {height} m");
            // :F1 formats the BMI to one decimal place (e.g., 22.9)
            Console.WriteLine($"Your calculated BMI is: {bmi:F1}");
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}