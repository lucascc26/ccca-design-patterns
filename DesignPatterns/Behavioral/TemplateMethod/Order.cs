using System.Collections.Generic;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Order
    {
        private readonly List<Item> _items;

        public Order()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public double GetTaxes()
        {
            var taxes = 0D;
            foreach (var item in _items)
            {
                if (item is TaxItem taxItem)
                    taxes += taxItem.CalculateTax();
            }
            return taxes;
        }
    }
}
