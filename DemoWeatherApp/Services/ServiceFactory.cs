using DemoWeatherApp.Domain.Enum;
using DemoWeatherApp.Domain.Interfaces;

namespace DemoWeatherApp.Services
{
    public class ServiceFactory
    {
        public virtual IService CreateService(ServiceType serviceType)
        {
            IService service = null;
            switch (serviceType)
            {
                case ServiceType.OPEN_WEATHER_MAP:
                    service = new OpenWeatherMapService();
                    break;
            }

            return service; 
        }
    }
}
