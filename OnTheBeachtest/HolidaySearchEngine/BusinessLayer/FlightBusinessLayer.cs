using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;


namespace HolidaySearchEngine.BusinessLayer
{
    public class FlightBusinessLayer : IFlightBusinessLayer
    {
        private IDataLayer Datalayer;

        public FlightBusinessLayer(IDataLayer dataLayer)
        {
            Datalayer = dataLayer;
        }

        IEnumerable<Flight> IFlightBusinessLayer.GetAvailableFlights(DateTime departureDate, string from, string to)
        {
            return Datalayer.GetFlights()
                .Where(f => f.DepartureDate == departureDate)
                .Where(f => f.From == from && f.To == to);
        }
    }
}
