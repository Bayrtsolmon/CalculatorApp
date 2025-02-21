namespace CalculatorApp
{
    public class BasicCalculator : Calculator, IArithmeticOperations
    {
        public void Add(double value)
        {
            Result += value;
        }

        public void Subtract(double value)
        {
            Result -= value;
        }
    }
}
