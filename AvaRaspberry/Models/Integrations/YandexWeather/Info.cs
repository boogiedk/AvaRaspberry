namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Info
    {
        public bool N { get; set; }
        public int Geoid { get; set; }
        public string Url { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public Tzinfo Tzinfo { get; set; }
        public int DefPressureMm { get; set; }
        public int DefPressurePa { get; set; }
        public string Slug { get; set; }
        public int Zoom { get; set; }
        public bool Nr { get; set; }
        public bool Ns { get; set; }
        public bool Nsr { get; set; }
        public bool P { get; set; }
        public bool F { get; set; }
        public bool H { get; set; }
    }
}