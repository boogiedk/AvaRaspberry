using System;
#pragma warning disable 8618

namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class YandexWeatherResponse
    {
        public int Now { get; set; }
        public DateTime NowDt { get; set; }
        public Info Info { get; set; }
        public Fact Fact { get; set; }
    }
}