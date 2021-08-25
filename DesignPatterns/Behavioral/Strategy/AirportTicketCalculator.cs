using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class AirportTicketCalculator : ITicketCalculator
    {
        public double Calculate(DateTime checkInDate, DateTime checkOutDate)
        {
            var period = (checkOutDate.Ticks / 10000 - checkInDate.Ticks / 10000) / (1000 * 60 * 60);
            var amount = 10D;
            var remainingHours = period - 3;
            
            if (remainingHours > 0)
                amount += remainingHours * 3;

            return amount;
        }
    }
}
