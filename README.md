# Lots-Calculator

# Position Size Calculator for Forex Trading
A simple Position Size Calculator for Forex Trading, designed to work with USD pairs and Euro pairs.

## Table of Contents
- Introduction
- Features
- Usage
- Installation
- Contributing
- License

## Introduction
The Position Size Calculator is a console application written in C# for calculating position sizes in Forex trading. It focuses on USD pairs and Euro pairs, providing an easy way to determine the appropriate lot size based on your account size and risk percentage.

## Features
- **Account Size Visualization:** Displays a bar chart of two account sizes with customizable colors.
- **Risk-Based Lot Calculation:** Utilizes a risk percentage to calculate the appropriate lot size for each account.
- **Commission Consideration:** Takes into account a fixed commission per lot when calculating the final lot size.

## Usage
1. **Initialize:**
Run the application to initialize and visualize the account sizes.
```bash
dotnet run
```
2. Follow the Instructions:
  - Enter the stop-loss size (in pips) for each account when prompted.
3. View Results:
  - The application will display the calculated lot size for each account based on the provided information.

## Installation
Ensure you have .NET SDK installed.
```bash
git clone https://github.com/your-username/position-size-calculator.git
cd position-size-calculator
dotnet run
```
## Contributing
Feel free to contribute to the project by opening issues or submitting pull requests. Your feedback and contributions are highly appreciated.
