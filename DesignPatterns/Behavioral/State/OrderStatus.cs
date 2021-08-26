namespace DesignPatterns.Behavioral.State
{
    public abstract class OrderStatus
    {
        protected readonly Order Order;

        public abstract string Value { get; }

        public OrderStatus(Order order)
        {
            Order = order;
        }

        public abstract void Open();
        public abstract void Confirm();
        public abstract void Cancel();
        public abstract void Refund();
    }
}
