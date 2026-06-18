# Currency Converter (USD to EUR)

A lightweight C# console application designed to perform accurate currency conversion from US Dollars (USD) to Euros (EUR). This project focuses on utilizing constants, user input handling, and formatted string output.

## Features
- **Precise Calculation:** Uses the `double` data type for accurate monetary representation.
- **Fixed Exchange Rate:** Implements a constant exchange rate for consistent conversion results.
- **Formatted Output:** Displays results rounded to two decimal places (e.g., $10.00 = €9.20).

## Technical Stack
- **Language:** C#
- **Framework:** .NET 8.0
- **Development Environment:** JetBrains Rider

## Implementation Details
The conversion logic follows the basic multiplication principle:
$$EUR = USD \times ExchangeRate$$

The program ensures data integrity by declaring the exchange rate as a `const` variable, preventing accidental modifications during runtime.
