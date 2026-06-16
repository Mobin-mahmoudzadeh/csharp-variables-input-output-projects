using System;

namespace _01_StudentGradeCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            // --- STEP 1: Welcome Message & Inputs ---
            Console.WriteLine("=== Student Grade Calculator ===");
            Console.WriteLine("Please enter the student details below:\n");
            
            //Get Student Name 
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            
            // Get Grades for 5 subjects
            Console.Write("Enter Math grade: ");
            double mathGrade = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Physics grade: ");
            double physicsGrade = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Chemistry garde: ");
            double chemistryGrade = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Biology garde: ");
            double biologyGrade = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Geography grade: ");
            double geographyGrade = Convert.ToDouble(Console.ReadLine());
            
            // --- STEP 2: Calculations & Logic ---
            // Summing up all grades
            double totalSum = mathGrade + physicsGrade + chemistryGrade + biologyGrade + geographyGrade;
            
            // Calculating the average (divided by 5 subjects)
            double averageGrade = totalSum / 5;

            // Determining pass/fail status using ternary operator
            string status = averageGrade >= 12.0 ? "Passed" : "Failed";
            
            // --- STEP 3: Displaying the Report Card --- 
            Console.WriteLine("\n=============================");
            Console.WriteLine("       REPORT CARD       ");
            Console.WriteLine("=============================");
            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Total Marks : {totalSum} / 100");
            Console.WriteLine($"Average Grade : {averageGrade:F2}");
            Console.WriteLine($"Final Status : {status}");
            Console.WriteLine("=============================");
            
            // Keeps the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }    
    }
}
