using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeather.MVVM.ViewModel
{
    public class WeatherViewModel
    {
        private async Task <Location> GetCoordinatesAsync(string address)
        {
            IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

            Locaction locaction = locations?.FirstOrDefault();
            if (location != null) 
            {
                Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                return Location;
            }

        }
    }
}
