# 02. Age Calculator ⏳

A C# console application designed to calculate a user's age based on their birth year and the current year (2026). This project focuses on integer data types and constants.

## 📝 Project Overview
The program prompts the user to enter the year they were born. Using a hardcoded constant for the current year (2026), it performs a basic subtraction to determine the user's age and prints a clean, formatted message to the console.

## 🛠️ Concepts & Features Covered
- **Constants (`const`):** Using the `const` keyword to declare a fixed value (`CurrentYear = 2026`) that cannot be altered during runtime.
- **Integer Data Type (`int`):** Utilizing `int` instead of `double` since years and ages are always whole numbers.
- **Type Conversion:** Using `Convert.ToInt32()` to parse the string input from `Console.ReadLine()` into a valid integer.
- **Basic Arithmetic Operations:** Practicing simple subtraction within C#.

## 💻 Sample Output
```text
=== Age Calculator ===
Enter your birth year (e.g., 2005): 2011

---------------------------------
In the year 2026, you are 15 years old.
---------------------------------