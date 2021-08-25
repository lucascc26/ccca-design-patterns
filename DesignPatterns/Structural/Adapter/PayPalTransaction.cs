namespace DesignPatterns.Structural.Adapter
{
    public class PayPalTransaction
    {
        public string Id { get; }
        public double Amount { get; }
        public string Status { get; }

        public PayPalTransaction(string id, double amount, string status)
        {
            Id = id;
            Amount = amount;
            Status = status;
        }
    }
}
