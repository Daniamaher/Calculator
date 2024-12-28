using System;
using Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double y = Convert.ToDouble(Console.ReadLine());

        Calculator.Calculator calculator = new Calculator.Calculator(x, y);

        Console.WriteLine($"Sum: {calculator.Add()}");
        Console.WriteLine($"Difference: {calculator.Subtract()}");
        Console.WriteLine($"Product: {calculator.Multiply()}");

        double result = calculator.Divide();
        if (double.IsNaN(result))
        {
            Console.WriteLine("Quotient: Cannot divide by zero");
        }
        else
        {
            Console.WriteLine($"Quotient: {result}");
        }
    }
}
