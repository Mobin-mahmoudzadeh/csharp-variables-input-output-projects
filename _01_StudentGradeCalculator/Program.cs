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
        }
    }
}
