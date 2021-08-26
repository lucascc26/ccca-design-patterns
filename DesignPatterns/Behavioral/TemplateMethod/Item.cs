namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Item
    {
        public string Category { get; }
        public string Description { get; }
        public double Price { get; }

        public Item(string category, string description, double price)
        {
            Category = category;
            Description = description;
            Price = price;
        }
    }
}
