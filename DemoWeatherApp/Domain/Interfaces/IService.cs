using DemoWeatherApp.Domain.Entities;

namespace DemoWeatherApp.Domain.Interfaces
{
    public interface IService
    {
        WeatherInfo GetWeatherInfo(double latitude, double longitude);
    }
}
