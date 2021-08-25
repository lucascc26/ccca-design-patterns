using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Ticket
    {
        public string Plate { get; private set; }
        public DateTime CheckInDate { get; private set; }

        public Ticket(string plate, DateTime checkInDate)
        {
            Plate = plate;
            CheckInDate = checkInDate;
        }
    }
}
