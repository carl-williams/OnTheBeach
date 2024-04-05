﻿using HolidaySearchEngine.Interfaces;
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
                "MAN",
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
                "LGW",
                "AGP"
            );

            Assert.That(flights.Count, Is.EqualTo(2));
            Assert.That(flights.Any(f => f.Id == 11), Is.True);
            Assert.That(flights.Any(f => f.Id == 12), Is.True);
        }
    }
}
