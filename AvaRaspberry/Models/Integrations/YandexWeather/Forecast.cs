using System.Collections.Generic;

namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Forecast
    {
        public string Date { get; set; }
        public int DateTs { get; set; }
        public int Week { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string RiseBegin { get; set; }
        public string SetEnd { get; set; }
        public int MoonCode { get; set; }
        public string MoonText { get; set; }
    }
}