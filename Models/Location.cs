namespace CurrentWeatherApp.Models
{
    /// <summary>
    /// Location model to represent a place.
    /// </summary>
    internal class Location
    {
        public string? Name { get; set; }
        public decimal Lon { get; set; } // Longitude of the location
        public decimal Lat { get; set; } // Latitude of the location
        public string? Country { get; set; }
        public string? State { get; set; }
    }
}
