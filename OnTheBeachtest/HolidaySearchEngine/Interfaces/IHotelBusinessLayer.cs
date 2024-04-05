using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.Interfaces
{
    public interface IHotelBusinessLayer
    {
        IEnumerable<Hotel> GetAvaliableHotels(string localAirport, DateTime arrivalDate, int duration);
    }
}
