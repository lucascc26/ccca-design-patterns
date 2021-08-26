namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class TaxItem : Item
    {
        public TaxItem(string category, string description, double price)
            : base(category, description, price)
        {
        }

        public double CalculateTax()
        {
            return (Price * GetTax()) / 100;
        }

        protected abstract double GetTax();
    }
}
