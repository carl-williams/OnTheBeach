using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;

namespace HolidaySearchEngineTest.BusinessLayer
{
    public class HolidayBusinessLayer : IHolidayBusinessLayer
    {
        IEnumerable<Holiday> IHolidayBusinessLayer.GetAvaliableHolidays(HoldiayParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
