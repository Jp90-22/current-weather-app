using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CurrentWeatherApp.Models;
using System.Globalization;

namespace CurrentWeatherApp
{
    public partial class WeatherForm : Form
    {
        /// <summary>
        /// Key to access to the Open Weather API.
        /// </summary>
        const string API_KEY = "42460d35e43901f50c4977c50b9c2642";
        const string UNITS = "metric";

        HttpClient weatherApiClient;
        CultureInfo cultureInfo;

        public WeatherForm()
        {
            InitializeComponent();

            weatherApiClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.openweathermap.org/"),
            };

            cultureInfo = new CultureInfo("en-US");
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            // Hide all weather information labels
            HideInfoLabels();

            // Hide progress bar
            ProgressBar.Visible = false;
        }

        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LocationTextBox.Text))
            {
                ProgressBar.Visible = true;

                try
                {
                    // Get the coordinates of the location
                    Location coordinates = await GetCoordinatesAsync(LocationTextBox.Text);
                    ProgressBar.Value = 25;

                    // Get and display the weather
                    WeatherInfo weatherInfo = await GetWeatherInfoAsync(coordinates);
                    ProgressBar.Value = 50;

                    SetLatLabel.Text = weatherInfo.Coord.Lat.ToString();
                    SetLonLabel.Text = weatherInfo.Coord.Lon.ToString();
                    SetLocationLabel.Text = $"{coordinates.Name}, {coordinates.State}, {coordinates.Country}";
                    SetTimeZoneLabel.Text = ConverShiftToTimeZone(weatherInfo.TimeZone);

                    TempLabel.Text = $"{weatherInfo.Main.Temp.ToString("0")} °C";
                    FeelsLikeLabel.Text = $"Feels like {weatherInfo.Main.Feels_like.ToString("0")} °C";
                    DescriptionLabel.Text = weatherInfo.Weather[0].Description;

                    WeatherInLocationLabel.Text = $"Weather in {coordinates.Name}";
                    SetMinTempLabel.Text = weatherInfo.Main.Temp_min.ToString("0.00") + "°";
                    SetMaxTempLabel.Text = weatherInfo.Main.Temp_max.ToString("0.00") + "°";
                    SetPressureLabel.Text = weatherInfo.Main.Pressure.ToString() + " hPa";
                    SetHumidityLabel.Text = weatherInfo.Main.Humidity.ToString() + "%";
                    SetWindSpedLabel.Text = weatherInfo.Wind.Speed.ToString("0.00") + " m/s";
                    ProgressBar.Value = 75;

                    // Set weather icon
                    WeatherIconPictureBox.LoadAsync($"https://openweathermap.org/img/wn/{weatherInfo.Weather[0].Icon}@2x.png");
                    WeatherIconPictureBox.BackColor = Color.MidnightBlue;

                    // Display information
                    ShowInfoLabels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ProgressBar.Value = 100;
                ProgressBar.Visible = false;
                ProgressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("The location should be filled!", "Fill the location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hide all weather information labels.
        /// </summary>
        private void HideInfoLabels()
        {
            TempLabel.Visible = false;
            FeelsLikeLabel.Visible = false;
            DescriptionLabel.Visible = false;

            LatLabel.Visible = false;
            SetLatLabel.Visible = false;
            LonLabel.Visible = false;
            SetLonLabel.Visible = false;
            SetLocationLabel.Visible = false;
            TimeZoneLabel.Visible = false;
            SetTimeZoneLabel.Visible = false;

            WeatherInLocationLabel.Visible = false;
            MinTempLabel.Visible = false;
            SetMinTempLabel.Visible = false;
            MaxTempLabel.Visible = false;
            SetMaxTempLabel.Visible = false;
            PressureLabel.Visible = false;
            SetPressureLabel.Visible = false;
            HumidityLabel.Visible = false;
            SetHumidityLabel.Visible = false;
            WindSpeedLabel.Visible = false;
            SetWindSpedLabel.Visible = false;
        }

        /// <summary>
        /// Show all weather information labels.
        /// </summary>
        private void ShowInfoLabels()
        {
            TempLabel.Visible = true;
            FeelsLikeLabel.Visible = true;
            DescriptionLabel.Visible = true;

            LatLabel.Visible = true;
            SetLatLabel.Visible = true;
            LonLabel.Visible = true;
            SetLonLabel.Visible = true;
            SetLocationLabel.Visible = true;
            TimeZoneLabel.Visible = true;
            SetTimeZoneLabel.Visible = true;

            WeatherInLocationLabel.Visible = true;
            MinTempLabel.Visible = true;
            SetMinTempLabel.Visible = true;
            MaxTempLabel.Visible = true;
            SetMaxTempLabel.Visible = true;
            PressureLabel.Visible = true;
            SetPressureLabel.Visible = true;
            HumidityLabel.Visible = true;
            SetHumidityLabel.Visible = true;
            WindSpeedLabel.Visible = true;
            SetWindSpedLabel.Visible = true;
        }

        /// <summary>
        /// Get the coordinates of a location.
        /// </summary>
        /// <param name="Location">Location string, can be a city name, country or state code.</param>
        /// <returns>Location object.</returns>
        private async Task<Location> GetCoordinatesAsync(string Location)
        {
            // Get geolocation json
            var response = await weatherApiClient.GetAsync($"geo/1.0/direct?q={Location}&limit=1&appid={API_KEY}");

            try
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Deserializate response
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var locations = JsonConvert.DeserializeObject<Location[]>(responseContent);

                    if (locations.Length > 0)
                    {
                        return locations[0];
                    }
                    else
                    {
                        MessageBox.Show("Sorry, we couldn't find the location.", "Couldn't find the location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw new Exception("Couldn't find the location!");
                    }
                }
                else
                {
                    throw new Exception("Bad response status code: " + response.StatusCode.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets weather information based on coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates of the asked weather.</param>
        /// <returns>Weather information.</returns>
        private async Task<WeatherInfo> GetWeatherInfoAsync(Location coordinates)
        {
            // Get weather json
            var response = await weatherApiClient.GetAsync($"data/2.5/weather?lat={coordinates.Lat}&lon={coordinates.Lon}&appid={API_KEY}&lang={cultureInfo.IetfLanguageTag}&units={UNITS}");

            try
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Deserializate response
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(responseContent);
                    return weatherInfo;
                }
                else
                {
                    throw new Exception("Bad response status code: " + response.StatusCode.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Conver a given shift time to a time zone object.
        /// </summary>
        /// <param name="shiftInSeconds">Shift in seconds.</param>
        /// <returns>Time zone converted.</returns>
        private string ConverShiftToTimeZone(int shiftInSeconds)
        {
            // Create a TimeSpan from the shift value
            TimeSpan shift = TimeSpan.FromSeconds(shiftInSeconds);

            // Get the local time zone
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            // Convert the shift to the time zone
            DateTimeOffset convertedTime = DateTimeOffset.UtcNow.ToOffset(shift).ToOffset(localTimeZone.GetUtcOffset(DateTimeOffset.UtcNow));

            // Return the converted time
            return convertedTime.ToString();
        }
    }
}
