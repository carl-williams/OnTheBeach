namespace HolidaySearchEngine.Models
{
    public class Holiday
    {
        public Flight Flight { get; }
        public Hotel Hotel { get; } 
        public Decimal TotalCost => throw new NotImplementedException();

        public Holiday(Flight flight, Hotel hotel)
        {
            Flight = flight;
            Hotel = hotel;
        }
    }
}
