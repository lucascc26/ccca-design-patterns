using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ShoppingMallTicketCalculator : ITicketCalculator
    {
        public double Calculate(DateTime checkInDate, DateTime checkOutDate)
        {
            var period = (checkOutDate.Ticks / 10000 - checkInDate.Ticks / 10000) / (1000 * 60 * 60);
            var amount = 0D;

            if (checkInDate.Hour >= 12 && checkInDate.Hour <= 14)
                amount = 0;
            else
                amount = period * 3;

            return amount;
        }
    }
}
