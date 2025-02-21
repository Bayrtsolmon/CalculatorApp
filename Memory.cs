using System.Collections.Generic;

namespace CalculatorApp
{
    public class Memory
    {
        private readonly List<MemoryItem> _memoryItems = new();

        public void Save(double value)
        {
            _memoryItems.Add(new MemoryItem(value));
        }

        public void Clear()
        {
            _memoryItems.Clear();
        }

        public IEnumerable<MemoryItem> GetMemoryItems()
        {
            return _memoryItems;
        }
    }
}
