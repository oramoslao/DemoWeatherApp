using DemoWeatherApp.Domain.Entities;
using DemoWeatherApp.Domain.Interfaces;
using Newtonsoft.Json;
using System.Net;
using System.Net.Cache;

namespace DemoWeatherApp.Services
{
    public class OpenWeatherMapService : IService
    {
        const string APPID = "b51fa7f5d7848f6022b227d547b7d3bc";

        public WeatherInfo GetWeatherInfo(double latitude, double longitude)
        {
            using (var client = new WebClient())
            {
                var url = $"http://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={APPID}&units=metric";
                client.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                var json = client.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo>(json);

                return result;
            }
        }
    }
}
