# 01. Student Grade Calculator 🎓

A console-based application built using C# and .NET to practice the fundamental concepts of variables, data types, and console Input/Output (I/O) operations.

## 📝 Project Overview
This program simulates a school report card system. It requests the user to input a student's name along with their grades for five core subjects. It then processes the data to calculate the total marks, average grade, and determines whether the student has passed or failed based on a standard academic threshold.

## 🛠️ Concepts & Features Covered
- **Console I/O:** Using `Console.Write()` for inline prompts and `Console.ReadLine()` to capture user entries.
- **Data Types & Variables:** Working with `string` for text and `double` for precision-based academic grades.
- **Type Conversion:** Utilizing `Convert.ToDouble()` to safely cast string inputs into numerical values for arithmetic operations.
- **Ternary Operator (`?:`):** Implementing a clean, single-line conditional expression to determine the passing status (`Passed` or `Failed`).
- **String Interpolation & Formatting:** Enhancing output readability using `$` and limiting decimal points to 2 digits via the `:F2` format specifier.

## 💻 Sample Output
```text
=== Student Grade Calculator ===
Please enter the student details below:

Enter Student Name: Amir
Enter Math grade: 18.5
Enter Physics grade: 17
Enter Chemistry grade: 15.25
Enter Biology grade: 19
Enter Geography grade: 16

=============================
         REPORT CARD         
=============================
Student Name : Amir
Total Marks  : 85.75 / 100
Average Grade: 17.15
Final Status : Passed
=============================
