using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeather.MVVM.Model
{

    public class CurrentWeather
    {
        public float temperature { get; set; }
        public float windspeed { get; set; }
        public int weathercode { get; set; }
    }


    public class WeatherData
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public CurrentWeather current_weather { get; set; } // ← Hinzugefügt
        public Hourly_Units hourly_units { get; set; }
        public Hourly hourly { get; set; }
        public Daily_Units daily_units { get; set; }
        public Daily daily { get; set; }
        public ObservableCollection<Daily2> daily2 { get; set; } =
            new ObservableCollection<Daily2>();
    }



    public class Hourly_Units
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Hourly
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
    }

    public class Daily_Units
    {
        public string time { get; set; }
        public string weather_code { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
    }

    public class Daily
    {
        public string[] time { get; set; }
        public int[] weather_code { get; set; }
        public float[] temperature_2m_max { get; set; }
        public float[] temperature_2m_min { get; set; }
    }
    public class Daily2
    {
        public string time { get; set; }
        public int weather_code { get; set; }
        public float temperature_2m_max { get; set; }
        public float temperature_2m_min { get; set; }
    }

}

