using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;
using HolidaySearchEngineTest.Mock;

namespace HolidaySearchEngineTest.Tests
{
    [TestFixture]
    internal class TestHollidayBL
    {
        private readonly IHolidayBusinessLayer HolidayBL;

        public TestHollidayBL()
        {
            HolidayBL = MockDI.GetRequiredService<IHolidayBusinessLayer>();
        }

        [Test]
        public void TestCustomer1()
        {
            var input = new HolidayParameters
            {
                DepartureDate = new DateTime(2023, 7, 1),
                From = ["MAN"],
                To = "AGP",
                Duration = 7
            };
            var holidays = HolidayBL.GetAvaliableHolidays(input);

            Assert.That(holidays.Count, Is.EqualTo(1));
            var holiday = holidays.First();


            Assert.That(holiday.Flight.Id, Is.EqualTo(2));
            Assert.That(holiday.Hotel.Id, Is.EqualTo(9));
        }

        [Test]
        public void TestCustomer2()
        {
            var input = new HolidayParameters
            {
                DepartureDate = new DateTime(2023, 6, 15),
                From = ["LCY", "LHR", "LGW", "STN", "SEN" ],
                To = "PMI",
                Duration = 10
            };
            var holidays = HolidayBL.GetAvaliableHolidays(input);

            Assert.That(holidays.Count, Is.EqualTo(1));
            var holiday = holidays.First();


            Assert.That(holiday.Flight.Id, Is.EqualTo(6));
            Assert.That(holiday.Hotel.Id, Is.EqualTo(5));
        }

        [Test]
        public void TestCustomer3()
        {
            var input = new HolidayParameters
            {
                DepartureDate = new DateTime(2022, 11, 10),
                From = Enumerable.Empty<string>(),
                To = "LPA",
                Duration = 14
            };
            var holidays = HolidayBL.GetAvaliableHolidays(input);

            Assert.That(holidays.Count, Is.EqualTo(1));
            var holiday = holidays.First();


            Assert.That(holiday.Flight.Id, Is.EqualTo(7));
            Assert.That(holiday.Hotel.Id, Is.EqualTo(6));
        }
    }
}
