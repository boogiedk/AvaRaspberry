namespace AvaRaspberry.Extenstion
{
    public class YandexWeather
    {
        public string ApiToken { get; set; }
    }

    public class Weather
    {
        public YandexWeather YandexWeather { get; set; }
    }

    public class Widgets
    {
        public Weather Weather { get; set; }
    }
}