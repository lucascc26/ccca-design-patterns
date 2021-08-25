namespace DesignPatterns.Structural.Adapter
{
    public class PagSeguroTransactionAdapter : ITransaction
    {
        public string TrackNumber { get; }
        public double Amount { get; }
        public TransactionStatus Status { get; }

        public PagSeguroTransactionAdapter(PagSeguroTransaction pagSeguroTransaction)
        {
            TrackNumber = pagSeguroTransaction.Code;
            Amount = pagSeguroTransaction.GrossAmount;
            Status = ConvertStatus(pagSeguroTransaction.Status);
        }

        private TransactionStatus ConvertStatus(int status)
        {
            switch (status)
            {
                case 1:
                    return TransactionStatus.WaitingPayment;
                case 2:
                    return TransactionStatus.Paid;
                case 3:
                    return TransactionStatus.Cancelled;
                default:
                    return TransactionStatus.None;
            }
        }
    }
}
