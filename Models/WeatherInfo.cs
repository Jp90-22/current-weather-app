using System;

namespace CurrentWeatherApp.Models
{
    /// <summary>
    /// WeatherInfo model to represent the weather information.
    /// </summary>
    internal class WeatherInfo
    {
        public Coordinates? Coord { get; set; }
        public Weather[]? Weather { get; set; }
        public Main? Main { get; set; }
        public Wind? Wind { get; set; }
        public int TimeZone { get; set; }
    }
}
