namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Beer : TaxItem
    {
        public Beer(string description, double price)
            : base("Beer", description, price)
        {
        }

        protected override double GetTax()
        {
            return 10D;
        }
    }
}
