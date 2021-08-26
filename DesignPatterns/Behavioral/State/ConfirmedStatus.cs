using System;

namespace DesignPatterns.Behavioral.State
{
    public class ConfirmedStatus : OrderStatus
    {
        public override string Value => "confirmed";

        public ConfirmedStatus(Order order) : base(order)
        {
        }

        public override void Cancel()
        {
            Order.Status = new CancelledStatus(Order);
        }

        public override void Confirm()
        {
            throw new Exception("The order is already confirmed");
        }

        public override void Open()
        {
            throw new Exception("The order is already confirmed");
        }

        public override void Refund()
        {
            Order.Status = new RefundedStatus(Order);
        }
    }
}
