namespace CurrentWeatherApp
{
    partial class WeatherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.TitleAppPictureBox = new System.Windows.Forms.PictureBox();
            this.WeatherIconPictureBox = new System.Windows.Forms.PictureBox();
            this.DividerLabel = new System.Windows.Forms.Label();
            this.ChooseLocationLabel = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.GetWeatherButton = new System.Windows.Forms.Button();
            this.LocationIconPictureBox = new System.Windows.Forms.PictureBox();
            this.WeatherInLocationLabel = new System.Windows.Forms.Label();
            this.MinTempLabel = new System.Windows.Forms.Label();
            this.MaxTempLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.SetMinTempLabel = new System.Windows.Forms.Label();
            this.SetMaxTempLabel = new System.Windows.Forms.Label();
            this.SetPressureLabel = new System.Windows.Forms.Label();
            this.SetHumidityLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.FeelsLikeLabel = new System.Windows.Forms.Label();
            this.SetLocationLabel = new System.Windows.Forms.Label();
            this.LatLabel = new System.Windows.Forms.Label();
            this.LonLabel = new System.Windows.Forms.Label();
            this.SetLatLabel = new System.Windows.Forms.Label();
            this.SetLonLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TimeZoneLabel = new System.Windows.Forms.Label();
            this.SetTimeZoneLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.SetWindSpedLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.TitleAppPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleAppPictureBox
            // 
            this.TitleAppPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TitleAppPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TitleAppPictureBox.Image")));
            this.TitleAppPictureBox.Location = new System.Drawing.Point(12, 0);
            this.TitleAppPictureBox.Name = "TitleAppPictureBox";
            this.TitleAppPictureBox.Size = new System.Drawing.Size(400, 200);
            this.TitleAppPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleAppPictureBox.TabIndex = 0;
            this.TitleAppPictureBox.TabStop = false;
            // 
            // WeatherIconPictureBox
            // 
            this.WeatherIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.WeatherIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeatherIconPictureBox.Location = new System.Drawing.Point(768, 76);
            this.WeatherIconPictureBox.Name = "WeatherIconPictureBox";
            this.WeatherIconPictureBox.Size = new System.Drawing.Size(172, 165);
            this.WeatherIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherIconPictureBox.TabIndex = 1;
            this.WeatherIconPictureBox.TabStop = false;
            // 
            // DividerLabel
            // 
            this.DividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DividerLabel.Location = new System.Drawing.Point(686, 244);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(400, 10);
            this.DividerLabel.TabIndex = 2;
            // 
            // ChooseLocationLabel
            // 
            this.ChooseLocationLabel.AutoSize = true;
            this.ChooseLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseLocationLabel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseLocationLabel.Location = new System.Drawing.Point(12, 203);
            this.ChooseLocationLabel.Name = "ChooseLocationLabel";
            this.ChooseLocationLabel.Size = new System.Drawing.Size(288, 49);
            this.ChooseLocationLabel.TabIndex = 3;
            this.ChooseLocationLabel.Text = "Choose a location";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationTextBox.Location = new System.Drawing.Point(12, 255);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.PlaceholderText = "Country or city name";
            this.LocationTextBox.Size = new System.Drawing.Size(400, 37);
            this.LocationTextBox.TabIndex = 4;
            this.LocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetWeatherButton
            // 
            this.GetWeatherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GetWeatherButton.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetWeatherButton.ForeColor = System.Drawing.Color.Black;
            this.GetWeatherButton.Location = new System.Drawing.Point(429, 255);
            this.GetWeatherButton.Name = "GetWeatherButton";
            this.GetWeatherButton.Size = new System.Drawing.Size(60, 37);
            this.GetWeatherButton.TabIndex = 5;
            this.GetWeatherButton.Text = "☀️";
            this.GetWeatherButton.UseVisualStyleBackColor = false;
            this.GetWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);
            // 
            // LocationIconPictureBox
            // 
            this.LocationIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LocationIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LocationIconPictureBox.Image")));
            this.LocationIconPictureBox.Location = new System.Drawing.Point(306, 199);
            this.LocationIconPictureBox.Name = "LocationIconPictureBox";
            this.LocationIconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.LocationIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LocationIconPictureBox.TabIndex = 6;
            this.LocationIconPictureBox.TabStop = false;
            // 
            // WeatherInLocationLabel
            // 
            this.WeatherInLocationLabel.AutoSize = true;
            this.WeatherInLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeatherInLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeatherInLocationLabel.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeatherInLocationLabel.ForeColor = System.Drawing.Color.Black;
            this.WeatherInLocationLabel.Location = new System.Drawing.Point(636, 275);
            this.WeatherInLocationLabel.MaximumSize = new System.Drawing.Size(432, 46);
            this.WeatherInLocationLabel.Name = "WeatherInLocationLabel";
            this.WeatherInLocationLabel.Size = new System.Drawing.Size(306, 46);
            this.WeatherInLocationLabel.TabIndex = 7;
            this.WeatherInLocationLabel.Text = "Weather in [Location]";
            // 
            // MinTempLabel
            // 
            this.MinTempLabel.AutoSize = true;
            this.MinTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinTempLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinTempLabel.ForeColor = System.Drawing.Color.Black;
            this.MinTempLabel.Location = new System.Drawing.Point(630, 340);
            this.MinTempLabel.Name = "MinTempLabel";
            this.MinTempLabel.Size = new System.Drawing.Size(166, 32);
            this.MinTempLabel.TabIndex = 8;
            this.MinTempLabel.Text = "Minimum temp:";
            // 
            // MaxTempLabel
            // 
            this.MaxTempLabel.AutoSize = true;
            this.MaxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxTempLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTempLabel.ForeColor = System.Drawing.Color.Black;
            this.MaxTempLabel.Location = new System.Drawing.Point(630, 387);
            this.MaxTempLabel.Name = "MaxTempLabel";
            this.MaxTempLabel.Size = new System.Drawing.Size(172, 32);
            this.MaxTempLabel.TabIndex = 9;
            this.MaxTempLabel.Text = "Maximum temp:";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PressureLabel.ForeColor = System.Drawing.Color.Black;
            this.PressureLabel.Location = new System.Drawing.Point(630, 434);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(112, 32);
            this.PressureLabel.TabIndex = 10;
            this.PressureLabel.Text = "Pressure:";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HumidityLabel.ForeColor = System.Drawing.Color.Black;
            this.HumidityLabel.Location = new System.Drawing.Point(630, 481);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(109, 32);
            this.HumidityLabel.TabIndex = 11;
            this.HumidityLabel.Text = "Humidity:";
            // 
            // SetMinTempLabel
            // 
            this.SetMinTempLabel.AutoSize = true;
            this.SetMinTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetMinTempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetMinTempLabel.ForeColor = System.Drawing.Color.Black;
            this.SetMinTempLabel.Location = new System.Drawing.Point(890, 338);
            this.SetMinTempLabel.MaximumSize = new System.Drawing.Size(161, 32);
            this.SetMinTempLabel.Name = "SetMinTempLabel";
            this.SetMinTempLabel.Size = new System.Drawing.Size(68, 28);
            this.SetMinTempLabel.TabIndex = 12;
            this.SetMinTempLabel.Text = "[data]";
            // 
            // SetMaxTempLabel
            // 
            this.SetMaxTempLabel.AutoSize = true;
            this.SetMaxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetMaxTempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetMaxTempLabel.ForeColor = System.Drawing.Color.Black;
            this.SetMaxTempLabel.Location = new System.Drawing.Point(890, 385);
            this.SetMaxTempLabel.MaximumSize = new System.Drawing.Size(161, 32);
            this.SetMaxTempLabel.Name = "SetMaxTempLabel";
            this.SetMaxTempLabel.Size = new System.Drawing.Size(68, 28);
            this.SetMaxTempLabel.TabIndex = 13;
            this.SetMaxTempLabel.Text = "[data]";
            // 
            // SetPressureLabel
            // 
            this.SetPressureLabel.AutoSize = true;
            this.SetPressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetPressureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetPressureLabel.ForeColor = System.Drawing.Color.Black;
            this.SetPressureLabel.Location = new System.Drawing.Point(890, 428);
            this.SetPressureLabel.MaximumSize = new System.Drawing.Size(161, 32);
            this.SetPressureLabel.Name = "SetPressureLabel";
            this.SetPressureLabel.Size = new System.Drawing.Size(68, 28);
            this.SetPressureLabel.TabIndex = 14;
            this.SetPressureLabel.Text = "[data]";
            // 
            // SetHumidityLabel
            // 
            this.SetHumidityLabel.AutoSize = true;
            this.SetHumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetHumidityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetHumidityLabel.ForeColor = System.Drawing.Color.Black;
            this.SetHumidityLabel.Location = new System.Drawing.Point(890, 477);
            this.SetHumidityLabel.MaximumSize = new System.Drawing.Size(161, 32);
            this.SetHumidityLabel.Name = "SetHumidityLabel";
            this.SetHumidityLabel.Size = new System.Drawing.Size(68, 28);
            this.SetHumidityLabel.TabIndex = 15;
            this.SetHumidityLabel.Text = "[data]";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempLabel.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TempLabel.ForeColor = System.Drawing.Color.White;
            this.TempLabel.Location = new System.Drawing.Point(592, 52);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TempLabel.Size = new System.Drawing.Size(150, 68);
            this.TempLabel.TabIndex = 16;
            this.TempLabel.Text = "36 °C";
            // 
            // FeelsLikeLabel
            // 
            this.FeelsLikeLabel.AutoSize = true;
            this.FeelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeelsLikeLabel.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeelsLikeLabel.ForeColor = System.Drawing.Color.Black;
            this.FeelsLikeLabel.Location = new System.Drawing.Point(530, 136);
            this.FeelsLikeLabel.Name = "FeelsLikeLabel";
            this.FeelsLikeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FeelsLikeLabel.Size = new System.Drawing.Size(206, 37);
            this.FeelsLikeLabel.TabIndex = 17;
            this.FeelsLikeLabel.Text = "Feels like [gade]";
            this.FeelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetLocationLabel
            // 
            this.SetLocationLabel.AutoSize = true;
            this.SetLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetLocationLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetLocationLabel.ForeColor = System.Drawing.Color.White;
            this.SetLocationLabel.Location = new System.Drawing.Point(27, 424);
            this.SetLocationLabel.MaximumSize = new System.Drawing.Size(500, 32);
            this.SetLocationLabel.Name = "SetLocationLabel";
            this.SetLocationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetLocationLabel.Size = new System.Drawing.Size(311, 32);
            this.SetLocationLabel.TabIndex = 18;
            this.SetLocationLabel.Text = "Location name, state, country";
            this.SetLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LatLabel
            // 
            this.LatLabel.AutoSize = true;
            this.LatLabel.BackColor = System.Drawing.Color.Transparent;
            this.LatLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LatLabel.ForeColor = System.Drawing.Color.White;
            this.LatLabel.Location = new System.Drawing.Point(27, 314);
            this.LatLabel.Name = "LatLabel";
            this.LatLabel.Size = new System.Drawing.Size(103, 32);
            this.LatLabel.TabIndex = 19;
            this.LatLabel.Text = "Latitude:";
            // 
            // LonLabel
            // 
            this.LonLabel.AutoSize = true;
            this.LonLabel.BackColor = System.Drawing.Color.Transparent;
            this.LonLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LonLabel.ForeColor = System.Drawing.Color.White;
            this.LonLabel.Location = new System.Drawing.Point(27, 369);
            this.LonLabel.Name = "LonLabel";
            this.LonLabel.Size = new System.Drawing.Size(122, 32);
            this.LonLabel.TabIndex = 20;
            this.LonLabel.Text = "Longitude:";
            // 
            // SetLatLabel
            // 
            this.SetLatLabel.AutoSize = true;
            this.SetLatLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetLatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetLatLabel.ForeColor = System.Drawing.Color.White;
            this.SetLatLabel.Location = new System.Drawing.Point(219, 312);
            this.SetLatLabel.MaximumSize = new System.Drawing.Size(254, 32);
            this.SetLatLabel.Name = "SetLatLabel";
            this.SetLatLabel.Size = new System.Drawing.Size(68, 28);
            this.SetLatLabel.TabIndex = 21;
            this.SetLatLabel.Text = "[data]";
            // 
            // SetLonLabel
            // 
            this.SetLonLabel.AutoSize = true;
            this.SetLonLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetLonLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetLonLabel.ForeColor = System.Drawing.Color.White;
            this.SetLonLabel.Location = new System.Drawing.Point(219, 367);
            this.SetLonLabel.MaximumSize = new System.Drawing.Size(254, 32);
            this.SetLonLabel.Name = "SetLonLabel";
            this.SetLonLabel.Size = new System.Drawing.Size(68, 28);
            this.SetLonLabel.TabIndex = 22;
            this.SetLonLabel.Text = "[data]";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(530, 191);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(204, 32);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescriptionLabel.Size = new System.Drawing.Size(127, 32);
            this.DescriptionLabel.TabIndex = 23;
            this.DescriptionLabel.Text = "Descripton";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimeZoneLabel
            // 
            this.TimeZoneLabel.AutoSize = true;
            this.TimeZoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeZoneLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeZoneLabel.ForeColor = System.Drawing.Color.White;
            this.TimeZoneLabel.Location = new System.Drawing.Point(27, 479);
            this.TimeZoneLabel.Name = "TimeZoneLabel";
            this.TimeZoneLabel.Size = new System.Drawing.Size(124, 32);
            this.TimeZoneLabel.TabIndex = 24;
            this.TimeZoneLabel.Text = "Time zone:";
            // 
            // SetTimeZoneLabel
            // 
            this.SetTimeZoneLabel.AutoSize = true;
            this.SetTimeZoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetTimeZoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetTimeZoneLabel.ForeColor = System.Drawing.Color.White;
            this.SetTimeZoneLabel.Location = new System.Drawing.Point(219, 477);
            this.SetTimeZoneLabel.MaximumSize = new System.Drawing.Size(254, 32);
            this.SetTimeZoneLabel.Name = "SetTimeZoneLabel";
            this.SetTimeZoneLabel.Size = new System.Drawing.Size(68, 28);
            this.SetTimeZoneLabel.TabIndex = 25;
            this.SetTimeZoneLabel.Text = "[data]";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindSpeedLabel.ForeColor = System.Drawing.Color.Black;
            this.WindSpeedLabel.Location = new System.Drawing.Point(630, 528);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(139, 32);
            this.WindSpeedLabel.TabIndex = 26;
            this.WindSpeedLabel.Text = "Wind speed:";
            // 
            // SetWindSpedLabel
            // 
            this.SetWindSpedLabel.AutoSize = true;
            this.SetWindSpedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SetWindSpedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetWindSpedLabel.ForeColor = System.Drawing.Color.Black;
            this.SetWindSpedLabel.Location = new System.Drawing.Point(890, 526);
            this.SetWindSpedLabel.MaximumSize = new System.Drawing.Size(161, 32);
            this.SetWindSpedLabel.Name = "SetWindSpedLabel";
            this.SetWindSpedLabel.Size = new System.Drawing.Size(68, 28);
            this.SetWindSpedLabel.TabIndex = 27;
            this.SetWindSpedLabel.Text = "[data]";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 547);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(506, 29);
            this.ProgressBar.TabIndex = 28;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 599);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SetWindSpedLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.SetTimeZoneLabel);
            this.Controls.Add(this.TimeZoneLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SetLonLabel);
            this.Controls.Add(this.SetLatLabel);
            this.Controls.Add(this.LonLabel);
            this.Controls.Add(this.LatLabel);
            this.Controls.Add(this.SetLocationLabel);
            this.Controls.Add(this.FeelsLikeLabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.SetHumidityLabel);
            this.Controls.Add(this.SetPressureLabel);
            this.Controls.Add(this.SetMaxTempLabel);
            this.Controls.Add(this.SetMinTempLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.MaxTempLabel);
            this.Controls.Add(this.MinTempLabel);
            this.Controls.Add(this.WeatherInLocationLabel);
            this.Controls.Add(this.LocationIconPictureBox);
            this.Controls.Add(this.GetWeatherButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.ChooseLocationLabel);
            this.Controls.Add(this.DividerLabel);
            this.Controls.Add(this.WeatherIconPictureBox);
            this.Controls.Add(this.TitleAppPictureBox);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Weather App";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleAppPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TitleAppPictureBox;
        private System.Windows.Forms.PictureBox WeatherIconPictureBox;
        private System.Windows.Forms.Label DividerLabel;
        private System.Windows.Forms.Label ChooseLocationLabel;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button GetWeatherButton;
        private System.Windows.Forms.PictureBox LocationIconPictureBox;
        private System.Windows.Forms.Label WeatherInLocationLabel;
        private System.Windows.Forms.Label MinTempLabel;
        private System.Windows.Forms.Label MaxTempLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label SetMinTempLabel;
        private System.Windows.Forms.Label SetMaxTempLabel;
        private System.Windows.Forms.Label SetPressureLabel;
        private System.Windows.Forms.Label SetHumidityLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label FeelsLikeLabel;
        private System.Windows.Forms.Label SetLocationLabel;
        private System.Windows.Forms.Label LatLabel;
        private System.Windows.Forms.Label LonLabel;
        private System.Windows.Forms.Label SetLatLabel;
        private System.Windows.Forms.Label SetLonLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TimeZoneLabel;
        private System.Windows.Forms.Label SetTimeZoneLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label SetWindSpedLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
