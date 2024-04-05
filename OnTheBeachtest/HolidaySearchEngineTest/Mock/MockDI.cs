using HolidaySearchEngine.BusinessLayer;
using HolidaySearchEngine.Interfaces;
using HolidaySearchEngineTest.BusinessLayer;
using Microsoft.Extensions.DependencyInjection;

namespace HolidaySearchEngineTest.Mock
{
    internal static class MockDI 
    {
        public static IServiceProvider Provider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IDataLayer, MockDataLayer>();
            services.AddSingleton<IHotelBusinessLayer, HotelBusinessLayer>();
            services.AddSingleton<IFlightBusinessLayer, FlightBusinessLayer>();
            services.AddSingleton<IHolidayBusinessLayer, HolidayBusinessLayer>();

            return services.BuildServiceProvider();
        }

        public static T GetRequiredService<T>() where T: notnull
        {
            var provider = Provider();
            return provider.GetRequiredService<T>();
        }
    }
}
