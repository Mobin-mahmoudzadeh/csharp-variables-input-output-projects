using System;

namespace _04_CurrencyConverter
{
    class program
    {
        static void Main(string[] args)
        {
            const double UsdToEurRate = 0.92;

            Console.WriteLine("=== Currency Converter (USD to EUR) ===");
            Console.WriteLine("---------------------------------------");
            
            // --- STEP 2: Get Input ---
            Console.Write("Enter amount in USD: ");
            double usdAmount = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 3: Calculation ---
            double eurAmount = usdAmount * UsdToEurRate;
            
            // --- STEP 4: Display Output ---
            Console.WriteLine("\\n------------------- Result -------------------");
            Console.WriteLine($"{usdAmount:F2} USD is equal to {eurAmount:F2} EUR");
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}