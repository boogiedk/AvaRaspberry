namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Info
    {
        public Info(Tzinfo tzinfo)
        {
            Tzinfo = tzinfo;
        }

        public Tzinfo Tzinfo { get; set; }
    }
}