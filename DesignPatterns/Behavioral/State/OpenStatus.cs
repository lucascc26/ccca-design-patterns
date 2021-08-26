using System;

namespace DesignPatterns.Behavioral.State
{
    public class OpenStatus : OrderStatus
    {
        public override string Value => "open";

        public OpenStatus(Order order) : base(order)
        {
        }

        public override void Cancel()
        {
            Order.Status = new CancelledStatus(Order);
        }

        public override void Confirm()
        {
            Order.Status = new ConfirmedStatus(Order);
        }

        public override void Open()
        {
            throw new Exception("The order is already open");
        }

        public override void Refund()
        {
            throw new Exception("The order is open");
        }
    }
}
