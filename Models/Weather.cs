namespace CurrentWeatherApp.Models
{
    /// <summary>
    /// Weather model to indicate the type of weather in a location.
    /// </summary>
    internal class Weather
    {
        public int ID { get; set; }
        public string? Main { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
