using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;

namespace HolidaySearchEngineTest.BusinessLayer
{
    internal class HolidayBusinessLayer : IHolidayBusinessLayer
    {
        IEnumerable<Holiday> IHolidayBusinessLayer.GetAvaliableHolidays(HoldiayParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
