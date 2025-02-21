using System;

namespace CalculatorApp
{
    public class MemoryItem
    {
        public double Value { get; }
        public DateTime Timestamp { get; }

        public MemoryItem(double value)
        {
            Value = value;
            Timestamp = DateTime.Now;
        }
    }
}
