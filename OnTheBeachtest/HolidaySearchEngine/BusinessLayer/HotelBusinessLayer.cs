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
            throw new NotImplementedException();
        }

        decimal IHotelBusinessLayer.GetTotalPriceForStayForHotel(Hotel hotek)
        {
            throw new NotImplementedException();
        }
    }
}
