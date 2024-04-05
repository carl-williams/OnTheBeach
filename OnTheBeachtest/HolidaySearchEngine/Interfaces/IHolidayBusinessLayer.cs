using HolidaySearchEngine.Models;

namespace HolidaySearchEngine.Interfaces
{
    public interface IHolidayBusinessLayer
    {
        IEnumerable<Holiday> GetAvaliableHolidays(HolidayParameters parameters);
    }
}
