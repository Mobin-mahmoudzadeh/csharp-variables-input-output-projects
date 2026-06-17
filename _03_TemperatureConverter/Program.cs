using System;

namespace _03_TemperatureConverter
{
    class program
    {
        static void Main(string[] args)
        {
            // --- STEP 1: Display Welcome Message & Get Input ---
            Console.WriteLine("=== Temperature Converter (Celsius to Fahrenheit) ===");
            Console.WriteLine("-----------------------------------------------------");
            
            Console.Write("Enter temperature in Celsius (e.g., 25.5): ");
            
            // Using double to support decimal numbers like 36.6
            double celsius = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 2: Calculate Fahrenheit ---
            // Formula: (Celsius * 9 / 5) + 32
            double fahrenheit = (celsius * 9 / 5) + 32;
            
            // --- STEP 3: Display Results ---
            Console.WriteLine("\n------------------- Results -------------------");
            // :F1 limits the output to 1 decimal place (e.g., 77.9)
            Console.WriteLine($"{celsius:F1}°C is equal to {fahrenheit:F1}°F");
            Console.WriteLine("-----------------------------------------------");
            
            // Keep the console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
    }
};

