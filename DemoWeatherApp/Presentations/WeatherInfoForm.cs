using DemoWeatherApp.Domain.Enum;
using DemoWeatherApp.Domain.Interfaces;
using DemoWeatherApp.Extensions;
using DemoWeatherApp.Services;
using System;
using System.Device.Location;
using System.Globalization;
using System.Windows.Forms;

namespace DemoWeatherApp.App
{
    public partial class WeatherInfoForm : Form
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsInitialLoaded { get; set; }
        public IService service;
        const string DATE_TIME_FORMAT = "ddd, MMMM dd yyyy HH:mm";

        public WeatherInfoForm()
        {
            InitializeComponent();

            lbl_lat.Text = string.Empty;
            lbl_lon.Text = string.Empty;
            ClearInfo();

            InitializeService();
        }

        private void InitializeService()
        {
            var factory = new ServiceFactory();
            service = factory.CreateService(ServiceType.OPEN_WEATHER_MAP);

        }

        private void ClearInfo()
        {
            lbl_location.Text = string.Empty;
            lbl_temp.Text = string.Empty;
            lbl_datetime.Text = string.Empty;
        }

        private void GetWeatherInfo()
        {
            var weaterInfo = service.GetWeatherInfo(Latitude, Longitude);
            var countryName = new RegionInfo(weaterInfo.Sys.Country.ToLower()).EnglishName;
            lbl_location.Text = $"{weaterInfo.Name}, {countryName}";
            lbl_temp.Text = $"{Math.Round(weaterInfo.Main.Temp)}°";
            lbl_datetime.Text = weaterInfo.Dt.GetDateTime().ToString(DATE_TIME_FORMAT);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsInitialLoaded = false;
            var watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += Watcher_PositionChaged;
            watcher.Start();

        }

        private void Watcher_PositionChaged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (!e.Position.Location.IsUnknown && Latitude != e.Position.Location.Latitude || Longitude != e.Position.Location.Longitude)
            {
                Latitude = e.Position.Location.Latitude;
                Longitude = e.Position.Location.Longitude;
                lbl_lat.Text = $"Latitude: {Math.Round(Latitude, 2)}";
                lbl_lon.Text = $"Longitude: {Math.Round(Longitude, 2)}";

                if (IsInitialLoaded == false)
                {
                    IsInitialLoaded = true;
                    GetWeatherInfo();
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            ClearInfo();
            GetWeatherInfo();
        }
    }
}
