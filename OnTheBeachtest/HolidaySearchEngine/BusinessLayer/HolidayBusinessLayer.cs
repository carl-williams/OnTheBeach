using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;

namespace HolidaySearchEngineTest.BusinessLayer
{
    public class HolidayBusinessLayer : IHolidayBusinessLayer
    {
        private IHotelBusinessLayer HotelBL;
        private IFlightBusinessLayer FlightBL;

        public HolidayBusinessLayer(IHotelBusinessLayer hotelBL, IFlightBusinessLayer flightBL)
        {
            HotelBL = hotelBL;
            FlightBL = flightBL;
        }

        IEnumerable<Holiday> IHolidayBusinessLayer.GetAvaliableHolidays(HolidayParameters parameters)
        {
            var hotels = HotelBL.GetAvaliableHotels(parameters.To, parameters.DepartureDate, parameters.Duration);

            throw new NotImplementedException();


        }
    }
}
