namespace DemoWeatherApp.Domain.Entities
{
    public class WeatherInfo
    {
        public Coord Coord { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public double Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public string Name { get; set; }
    }
}
