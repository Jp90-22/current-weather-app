namespace CurrentWeatherApp.Models
{
    /// <summary>
    /// The Main model has all relevant information about weather.
    /// </summary>
    internal class Main
    {
        public double Temp { get; set; } // Temperature in Celcius
        public double Feels_like { get; set; } // The "feels like" temparature
        public double Temp_max { get; set; } 
        public double Temp_min { get; set; }
        public int Pressure { get; set; } // Atmospheric pressure in hPa
        public int Humidity { get; set; } // Humidity in %
    }
}
