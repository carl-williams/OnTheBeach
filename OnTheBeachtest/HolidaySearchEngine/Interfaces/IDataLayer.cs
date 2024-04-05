using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.Interfaces
{
    public interface IDataLayer
    {
        public IEnumerable<Flight> GetFlights();

        public IEnumerable<Hotel> GetHotels();
    }
}
