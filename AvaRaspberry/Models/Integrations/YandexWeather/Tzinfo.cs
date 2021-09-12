namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Tzinfo
    {
        public Tzinfo(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}