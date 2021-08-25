using DesignPatterns.Behavioral.Strategy;
using System;
using Xunit;

namespace DesignPatterns.Tests.Behavioral.Strategy
{
    public class ParkingLotTests
    {
        [Fact]
        public void Should_calculate_the_ticket_amount_of_a_car_parked_3_hours_at_the_beach()
        {
            var parkingLot = new ParkingLot(new BeachTicketCalculator());
            parkingLot.CheckIn("ABC-1234", new DateTime(2020, 10, 10, 10, 0, 0));
            var ticket = parkingLot.CheckOut("ABC-1234", new DateTime(2020, 10, 10, 13, 0, 0));
            Assert.Equal(15D, ticket.Amount);
        }

        [Fact]
        public void Should_calculate_the_ticket_amount_of_a_car_parked_10_hours_at_the_airport()
        {
            var parkingLot = new ParkingLot(new AirportTicketCalculator());
            parkingLot.CheckIn("ABC-1234", new DateTime(2020, 10, 10, 10, 0, 0));
            var ticket = parkingLot.CheckOut("ABC-1234", new DateTime(2020, 10, 10, 20, 0, 0));
            Assert.Equal(31D, ticket.Amount);
        }

        [Fact]
        public void Should_calculate_the_ticket_amount_of_a_car_parked_2_hours_at_the_shopping_mall_at_lunchtime()
        {
            var parkingLot = new ParkingLot(new ShoppingMallTicketCalculator());
            parkingLot.CheckIn("ABC-1234", new DateTime(2020, 10, 10, 12, 0, 0));
            var ticket = parkingLot.CheckOut("ABC-1234", new DateTime(2020, 10, 10, 14, 0, 0));
            Assert.Equal(0D, ticket.Amount);
        }
    }
}
