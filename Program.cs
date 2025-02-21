using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new();
            Memory memory = new();

            // Perform operations
            calculator.Add(10);
            Console.WriteLine($"Result after addition: {calculator.Result}");

            calculator.Subtract(5);
            Console.WriteLine($"Result after subtraction: {calculator.Result}");

            // Save result to memory
            memory.Save(calculator.Result);
            Console.WriteLine("Memory saved.");

            // Display memory contents
            foreach (var item in memory.GetMemoryItems())
            {
                Console.WriteLine($"Memory Item: {item.Value}, Saved at: {item.Timestamp}");
            }
        }
    }
}
