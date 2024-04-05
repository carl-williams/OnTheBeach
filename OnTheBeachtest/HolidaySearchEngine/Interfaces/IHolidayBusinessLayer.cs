using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.Interfaces
{
    public interface IHolidayBusinessLayer
    {
        IEnumerable<Holiday> GetAvaliableHolidays(HoldiayParameters parameters);
    }
}
