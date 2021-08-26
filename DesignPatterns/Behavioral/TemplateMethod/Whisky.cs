namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Whisky : TaxItem
    {
        public Whisky(string description, double price)
            : base("Whisky", description, price)
        {
        }

        protected override double GetTax()
        {
            return 20D;
        }
    }
}
