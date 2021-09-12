using System;
using System.Collections.Generic;

namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class YandexWeatherResponse
    {
        public int Now { get; set; }
        public DateTime NowDt { get; set; }
        public Info Info { get; set; }
        public Fact Fact { get; set; }
        public List<Forecast> Forecasts { get; set; }
    }
}