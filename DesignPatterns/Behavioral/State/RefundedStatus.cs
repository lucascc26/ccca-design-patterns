using System;

namespace DesignPatterns.Behavioral.State
{
    public class RefundedStatus : OrderStatus
    {
        public override string Value => "refunded";

        public RefundedStatus(Order order) : base(order)
        {
        }

        public override void Cancel()
        {
            throw new Exception("The order is already refunded");
        }

        public override void Confirm()
        {
            throw new Exception("The order is already refunded");
        }

        public override void Open()
        {
            throw new Exception("The order is already refunded");
        }

        public override void Refund()
        {
            throw new Exception("The order is already refunded");
        }
    }
}
