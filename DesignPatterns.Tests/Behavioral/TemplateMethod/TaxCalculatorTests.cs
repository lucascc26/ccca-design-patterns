using DesignPatterns.Behavioral.TemplateMethod;
using Xunit;

namespace DesignPatterns.Tests.Behavioral.TemplateMethod
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void Should_calculate_items_tax()
        {
            var order = new Order();
            order.AddItem(new Beer("Heineken", 20D));
            order.AddItem(new Whisky("Jack Daniels", 100D));
            order.AddItem(new Water("Imperatriz", 0D));

            var taxes = order.GetTaxes();

            Assert.Equal(22D, taxes);
        }
    }
}
