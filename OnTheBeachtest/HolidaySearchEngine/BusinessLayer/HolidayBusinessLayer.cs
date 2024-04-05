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

            var flights = FlightBL.GetAvailableFlights(parameters.DepartureDate, parameters.From, parameters.To).ToList();
            return HotelBL.GetAvaliableHotels(parameters.To, parameters.DepartureDate, parameters.Duration)
                .SelectMany(h => flights.Select(f => new Holiday(f, h)))
                .OrderBy(h => h.TotalCost);
        }
    }
}
