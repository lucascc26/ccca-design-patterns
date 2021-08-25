using DesignPatterns.Structural.Adapter;
using Xunit;

namespace DesignPatterns.Tests.Structural.Adapter
{
    public class TransactionTests
    {
        [Fact]
        public void Should_make_a_transaction_with_PagSeguro()
        {
            var pagSeguroTransaction = new PagSeguroTransaction("ABC123", 1000D, 2);
            var transaction = new PagSeguroTransactionAdapter(pagSeguroTransaction);
            Assert.Equal(TransactionStatus.Paid, transaction.Status);
        }

        [Fact]
        public void Should_make_a_transaction_with_PayPal()
        {
            var payPalTransaction = new PayPalTransaction("ABC123", 1000D, "S");
            var transaction = new PayPalTransactionAdapter(payPalTransaction);
            Assert.Equal(TransactionStatus.Paid, transaction.Status);
        }
    }
}
