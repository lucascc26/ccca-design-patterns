namespace DesignPatterns.Structural.Adapter
{
    public class PagSeguroTransaction
    {
        public PagSeguroTransaction(string code, double grossAmount, int status)
        {
            Code = code;
            GrossAmount = grossAmount;
            Status = status;
        }

        public string Code { get; }
        public double GrossAmount { get; }
        public int Status { get; }
    }
}
