namespace DesignPatterns.Structural.Adapter
{
    public enum TransactionStatus
    {
        None,
        WaitingPayment,
        Paid,
        Cancelled,
        Refunded
    }
}
