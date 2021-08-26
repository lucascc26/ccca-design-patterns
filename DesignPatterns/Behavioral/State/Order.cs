namespace DesignPatterns.Behavioral.State
{
    public class Order
    {
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = new OpenStatus(this);
        }

        public void Cancel()
        {
            Status.Cancel();
        }

        public void Confirm()
        {
            Status.Confirm();
        }

        public void Open()
        {
            Status.Open();
        }

        public void Refund()
        {
            Status.Refund();
        }
    }
}
