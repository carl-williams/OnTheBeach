using HolidaySearchEngine.Interfaces;
using HolidaySearchEngineTest.Mock;

namespace HolidaySearchEngineTest.Tests
{
    [TestFixture]
    internal class TestHotelBL
    {
        private readonly IHotelBusinessLayer HotelBL;

        public TestHotelBL()
        {
            HotelBL = MockDI.GetRequiredService<IHotelBusinessLayer>();
        }

        [Test]
        public void GetAllHotelsLocalToTFSFor20221105For7Nights()
        {
            var hotels = HotelBL.GetAvaliableHotels(
                "TFS",
                new DateTime(2022, 11, 05),
                7);

            Assert.That(hotels.Count, Is.EqualTo(2));
            Assert.That(hotels.Any(f => f.Id == 1), Is.True);
            Assert.That(hotels.Any(f => f.Id == 2), Is.True);
        }

        [Test]
        public void GetTotalPriceForHotelStay()
        {
            var rawData = MockDI.GetRequiredService<IDataLayer>();
            var hotel = rawData.GetHotels()
                .Where(h => h.Id == 4)
                .FirstOrDefault();
            Assert.That(hotel, Is.Not.Null);
            Assert.That(hotel.TotalPrice, Is.EqualTo(826d));
        }
    }
}
