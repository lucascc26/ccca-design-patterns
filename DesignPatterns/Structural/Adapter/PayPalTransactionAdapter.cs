namespace DesignPatterns.Structural.Adapter
{
    public class PayPalTransactionAdapter : ITransaction
    {
        public string TrackNumber { get; }
        public double Amount { get; }
        public TransactionStatus Status { get; }

        public PayPalTransactionAdapter(PayPalTransaction payPalTransaction)
        {
            TrackNumber = payPalTransaction.Id;
            Amount = payPalTransaction.Amount;
            Status = ConvertStatus(payPalTransaction.Status);
        }

        private TransactionStatus ConvertStatus(string status)
        {
            switch (status)
            {
                case "P":
                    return TransactionStatus.WaitingPayment;
                case "S":
                    return TransactionStatus.Paid;
                case "F":
                    return TransactionStatus.Refunded;
                default:
                    return TransactionStatus.None;
            }
        }
    }
}
