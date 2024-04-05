using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.Interfaces
{
    public interface IFlightBusinessLayer
    {
        public IEnumerable<Flight> GetAvailableFlights(DateTime departureDate, string from, string to);
    }
}
