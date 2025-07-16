using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeather.Converters
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            var code = (int)value;

            switch (code)
            {
                case 0: return "Clear sky";
                case 1:
                case 2:
                case 3: return "Mainly clear / Partly cloudy / Overcast";
                case 45:
                case 48: return "Fog / Rime fog";
                case 51:
                case 53:
                case 55: return "Drizzle (light to dense)";
                case 56:
                case 57: return "Freezing drizzle";
                case 61:
                case 63:
                case 65: return "Rain (slight to heavy)";
                case 66:
                case 67: return "Freezing rain";
                case 71:
                case 73:
                case 75: return "Snowfall";
                case 77: return "Snow grains";
                case 80:
                case 81:
                case 82: return "Rain showers";
                case 85:
                case 86: return "Snow showers";
                case 95: return "Thunderstorm";
                case 96:
                case 99: return "Thunderstorm with hail";
                default: return $"Unknown ({code})";
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
