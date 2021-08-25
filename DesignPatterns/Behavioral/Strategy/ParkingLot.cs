using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ParkingLot
    {
        private readonly ITicketCalculator _ticketCalculator;
        private readonly List<Ticket> _tickets;

        public ParkingLot(ITicketCalculator ticketCalculator)
        {
            _ticketCalculator = ticketCalculator;
            _tickets = new List<Ticket>();
        }

        public void CheckIn(string plate, DateTime checkInDate)
        {
            _tickets.Add(new Ticket(plate, checkInDate));
        }

        public CheckOutResult CheckOut(string plate, DateTime checkOutDate)
        {
            var ticket = _tickets.FirstOrDefault(t => t.Plate.Equals(plate));
            if (ticket == null)
                throw new Exception("Ticket not found");

            var amount = _ticketCalculator.Calculate(ticket.CheckInDate, checkOutDate);

            return new CheckOutResult(amount);
        }
    }
}
