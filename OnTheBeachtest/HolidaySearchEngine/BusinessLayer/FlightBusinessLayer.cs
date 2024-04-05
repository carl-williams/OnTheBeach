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

        IEnumerable<Flight> IFlightBusinessLayer.GetAvailableFlights(DateTime departureDate, IEnumerable<string> from, string to)
        {
            return Datalayer.GetFlights()
                .Where(f => f.DepartureDate == departureDate)
                .Where(f => f.From== from.FirstOrDefault() && f.To == to);
        }
    }
}
