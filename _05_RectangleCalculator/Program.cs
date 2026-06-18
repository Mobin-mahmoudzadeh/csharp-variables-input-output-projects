using System;

namespace _05_RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Rectangle Area Calculator ===");
            Console.WriteLine("---------------------------------");
            
            // --- STEP 1: Get Inputs ---
            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 2: Calculation ---
            double area =  width * length;
            
            // --- STEP 3: Display Result ---
            Console.WriteLine("\\n------------------- Result -------------------");
            Console.WriteLine($"width: {width:F2}, Length: {length:F2}");
            Console.WriteLine($"The area of the rectangle is: {area:F2}");
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

