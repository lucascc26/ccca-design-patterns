using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface ITicketCalculator
    {
        double Calculate(DateTime checkInDate, DateTime checkOutDate);
    }
}
