namespace CurrentWeatherApp.Models
{
    /// <summary>
    /// Wind model to display information about the wind in a location.
    /// </summary>
    internal class Wind
    {
        public double Speed { get; set; } // Speed of wind in m/s
        public ushort Deg { get; set; } // Direction of wind in degrees (0° - 360°) 
    }
}
