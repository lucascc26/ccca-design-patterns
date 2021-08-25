namespace DesignPatterns.Structural.Adapter
{
    public interface ITransaction
    {
        public string TrackNumber { get; }
        public double Amount { get; }
        public TransactionStatus Status { get; }
    }
}
