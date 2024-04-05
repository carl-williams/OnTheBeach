namespace HolidaySearchEngine.Models
{
    public class HoldiayParameters
    {
        public IEnumerable<string> From { get; set; }
        public string? To { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Duration { get; set; }
    }
}
