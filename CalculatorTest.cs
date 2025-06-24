using System;

class CalculatorTest
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine($"PI = {Calculator.PI}");
        Console.WriteLine($"Sum(3, 5) = {calc.Sum(3, 5)}");
        Console.WriteLine($"Multiply(4, 7) = {calc.Multiply(4, 7)}");
        Console.WriteLine($"Subtract(10, 4) = {calc.Subtract(10, 4)}");
        Console.WriteLine($"Divide(20, 5) = {calc.Divide(20, 5)}");
        Console.WriteLine($"Min(2, 7) = {calc.Min(2, 7)}");
        Console.WriteLine($"Min(2, 7, 1) = {calc.Min(2, 7, 1)}");
        Console.WriteLine($"Max(2, 7) = {calc.Max(2, 7)}");
        Console.WriteLine($"Max(2, 7, 10) = {calc.Max(2, 7, 10)}");
        Console.WriteLine($"Pow(2, 5) = {calc.Pow(2, 5)}");
        Console.WriteLine($"Pow(2, -3) = {calc.Pow(2, -3)}");
        Console.WriteLine($"GCD(24, 18) = {calc.GCD(24, 18)}");
        Console.WriteLine($"LCM(24, 18) = {calc.LCM(24, 18)}");
        Console.WriteLine($"Sqrt(16) = {calc.Sqrt(16)}");
        Console.WriteLine($"Sin(PI/2) = {calc.Sin(Calculator.PI / 2)}");
        Console.WriteLine("Random two-digit numbers:");
        for (int i = 0; i < 5; i++)
            Console.Write(calc.RandomTwoDigit() + " ");
        Console.WriteLine();
    }
}