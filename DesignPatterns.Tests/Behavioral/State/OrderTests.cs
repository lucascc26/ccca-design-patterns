using DesignPatterns.Behavioral.State;
using System;
using Xunit;

namespace DesignPatterns.Tests.Behavioral.State
{
    public class OrderTests
    {
        [Fact]
        public void Should_create_order_and_change_its_status_to_open()
        {
            var order = new Order();

            Assert.Equal("open", order.Status.Value);
        }

        [Fact]
        public void Should_create_order_and_confirm_it()
        {
            var order = new Order();
            order.Confirm();

            Assert.Equal("confirmed", order.Status.Value);
        }

        [Fact]
        public void Should_create_order_and_cancel_it()
        {
            var order = new Order();
            order.Cancel();

            Assert.Equal("cancelled", order.Status.Value);
        }

        [Fact]
        public void Should_fail_when_changing_order_status_to_open_after_confirmation()
        {
            var order = new Order();
            order.Confirm();

            var ex = Assert.Throws<Exception>(() => order.Open());
            Assert.Equal("The order is already confirmed", ex.Message);
        }

        [Fact]
        public void Should_fail_when_changing_order_status_to_open_after_cancellation()
        {
            var order = new Order();
            order.Cancel();

            var ex = Assert.Throws<Exception>(() => order.Open());
            Assert.Equal("The order is already cancelled", ex.Message);
        }

        [Fact]
        public void Should_create_order_and_refund_after_confirmation()
        {
            var order = new Order();
            order.Confirm();
            
            order.Refund();

            Assert.Equal("refunded", order.Status.Value);
        }
    }
}
