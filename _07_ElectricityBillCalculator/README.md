# Electricity Bill Calculator

A practical C# console application designed to calculate the total electricity utility bill based on total power consumption (in kWh) and the unit price per kWh. This project demonstrates basic arithmetic multiplication, variable handling, and professional currency/numeric output formatting using .NET 8.

## Features
- **Flexible Data Types:** Utilizes `double` to seamlessly handle both integer and decimal values for consumption and pricing.
- **Enhanced Readability:** Implements standard numeric formatting (`:N0`) to automatically add thousands separators for large currency values.
- **Structured Output:** Displays results in a clean, invoice-like format inside the terminal.

## Technical Stack
- **Language:** C#
- **Framework:** .NET 8.0
- **Development Environment:** JetBrains Rider

## Calculation Logic
The total bill is computed through a direct linear formula:
$$Total = Consumption \times PricePerKwh$$