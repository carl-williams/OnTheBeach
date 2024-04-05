using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.BusinessLayer
{
     public class HotelBusinessLayer : IHotelBusinessLayer
    {
        private IDataLayer Datalayer;

        public HotelBusinessLayer(IDataLayer dataLayer)
        {
            Datalayer = dataLayer;
        }

        IEnumerable<Hotel> IHotelBusinessLayer.GetAvaliableHotels(string localAirport, DateTime arrivalDate, int duration)
        {
            return Datalayer.GetHotels()
                .Where(h => h.Nights == duration)
                .Where(h => h.ArrivalDate == arrivalDate)
                .Where(h => h.LocalAirports.Contains(localAirport));
        }
    }
}
