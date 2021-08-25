namespace DesignPatterns.Behavioral.Strategy
{
    public class CheckOutResult
    {
        public double Amount { get; private set; }

        public CheckOutResult(double amount)
        {
            Amount = amount;
        }
    }
}
