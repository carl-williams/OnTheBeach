using HolidaySearchEngine.Interfaces;
using HolidaySearchEngineTest.Mock;

namespace HolidaySearchEngineTest.Tests
{
    [TestFixture]
    internal class TestFlightBL
    {
        private readonly IFlightBusinessLayer FlightBL;

        public TestFlightBL()
        {
            FlightBL = MockDI.GetRequiredService<IFlightBusinessLayer>();
        }

        [Test]
        public void GetFlightsAvailableFor20230701ManTfs()
        {
            var flights = FlightBL.GetAvailableFlights(
                new DateTime(2023, 7, 1),
                ["MAN"],
                "TFS"
            );

            Assert.That(flights.Count, Is.EqualTo(1));
            Assert.That(flights.First().Id, Is.EqualTo(1));
        }

        [Test]
        public void GetFlightsAvailableFor20230701LgwAgw()
        {
            var flights = FlightBL.GetAvailableFlights(
                new DateTime(2023, 7, 1),
                ["LGW"],
                "AGP"
            );

            Assert.That(flights.Count, Is.EqualTo(2));
            Assert.That(flights.Any(f => f.Id == 10), Is.True);
            Assert.That(flights.Any(f => f.Id == 11), Is.True);
        }

        [Test]
        public void GetAllFlightsToPMIFor20230615DepartingFromManOrLgw()
        {
            var flights = FlightBL.GetAvailableFlights(
                new DateTime(2023, 6, 15),
                ["MAN", "LGW"],
                "PMI"
            );

            Assert.That(flights.Count, Is.EqualTo(3));
            Assert.That(flights.Any(f => f.Id == 3), Is.True);
            Assert.That(flights.Any(f => f.Id == 5), Is.True);
            Assert.That(flights.Any(f => f.Id == 6), Is.True);
        }
        [Test]
        public void GetAllFlightsToPMIFor20230615()
        {
            var flights = FlightBL.GetAvailableFlights(
                new DateTime(2023, 6, 15),
                [],
                "PMI"
            );

            Assert.That(flights.Count, Is.EqualTo(4));
            Assert.That(flights.Any(f => f.Id == 3), Is.True);
            Assert.That(flights.Any(f => f.Id == 4), Is.True);
            Assert.That(flights.Any(f => f.Id == 5), Is.True);
            Assert.That(flights.Any(f => f.Id == 6), Is.True);
        }
    }
}
