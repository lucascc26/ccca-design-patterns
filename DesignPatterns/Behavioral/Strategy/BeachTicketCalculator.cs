using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BeachTicketCalculator : ITicketCalculator
    {
        public double Calculate(DateTime checkInDate, DateTime checkOutDate)
        {
            var period = (checkOutDate.Ticks / 10000 - checkInDate.Ticks / 10000) / (1000 * 60 * 60);
            var amount = period * 5;
            return amount;
        }
    }
}
