using System;

namespace DesignPatterns.Behavioral.State
{
    public class CancelledStatus : OrderStatus
    {
        public override string Value => "cancelled";

        public CancelledStatus(Order order) : base(order)
        {
        }

        public override void Cancel()
        {
            throw new Exception("The order is already cancelled");
        }

        public override void Confirm()
        {
            throw new Exception("The order is already cancelled");
        }

        public override void Open()
        {
            throw new Exception("The order is already cancelled");
        }

        public override void Refund()
        {
            throw new Exception("The order is already cancelled");
        }
    }
}
