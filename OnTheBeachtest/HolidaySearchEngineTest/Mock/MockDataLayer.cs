using HolidaySearchEngine.Interfaces;
using HolidaySearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HolidaySearchEngineTest.Mock
{
    internal class MockDataLayer : IDataLayer
    {
        private readonly string FlightFlie = "flights.json";
        private readonly string HotelFile = "hotels.json";
        private readonly string FileNameSpace;

        public MockDataLayer()
        {
#pragma warning disable CS8602 // The type and namespace will never be null.
            FileNameSpace = this.GetType().Namespace.ToString();
#pragma warning restore CS8602 // The type and namespace will never be null.
        }

        private IEnumerable<T> GetTestData<T>(string fileName)
        {
            string resourceName = $"{FileNameSpace}.{fileName}";
          
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                    throw new NotImplementedException("no such Query defined");
                using var reader = new StreamReader(stream);
                var json = reader.ReadToEnd();
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
                };

                var data = JsonSerializer.Deserialize<IEnumerable<T>>(json, jsonOptions);
                if (data != null)
                {
                    return data;
                }
                return Enumerable.Empty<T>(); 
            }
            catch (Exception ex)
            {
                throw new Exception($"Unable to Load '{fileName}'", ex);
            }
        }

        IEnumerable<Flight> IDataLayer.GetFlights()
        {
            return GetTestData<Flight>(FlightFlie);
        }

        IEnumerable<Hotel> IDataLayer.GetHotels()
        {
            return GetTestData<Hotel>(HotelFile);
        }
    }
}
