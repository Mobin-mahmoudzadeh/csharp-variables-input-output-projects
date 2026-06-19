using System;

namespace _08_ElectricityBillCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Electricity Bill Calculator ===");
            Console.WriteLine("-----------------------------------");
            
            // --- STEP 1: Get Inputs ---
            Console.Write("Enter electricity consumption in kwh (e.g., 350): ");
            double consumption = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter price per kwh (e.g., 1200): ");
            double pricePerKwh = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 2: Calculate Total Bill ---
            double totalBill = consumption * pricePerKwh;
            
            // --- STEP 3: Display Invoice Result ---
            Console.WriteLine("\n------------------- Invoice -------------------");
            Console.WriteLine($"Consumption   : {consumption} kWh");
            // :N0 adds thousands separators for better readability
            Console.WriteLine($"Price per kWh : {pricePerKwh:N0}");
            Console.WriteLine($"Total Bill    : {totalBill:N0}");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            
        }
    }
}