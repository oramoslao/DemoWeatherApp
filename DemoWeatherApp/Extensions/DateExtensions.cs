using System;

namespace DemoWeatherApp.Extensions
{
    public static class DateExtensions
    {
        public static DateTime GetDateTime(this double millisecound)
        {
            var day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            return day.AddSeconds(millisecound).ToLocalTime();
        }
    }
}
