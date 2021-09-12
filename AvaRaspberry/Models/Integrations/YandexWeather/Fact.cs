namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Fact
    {
        public int ObsTime { get; set; }
        public int Uptime { get; set; }
        public int Temp { get; set; }
        public int FeelsLike { get; set; }
        public string Icon { get; set; }
        public string Condition { get; set; }
        public string Cloudness { get; set; }
        public int PrecType { get; set; }
        public int PrecProb { get; set; }
        public int PrecStrength { get; set; }
        public bool IsThunder { get; set; }
        public double WindSpeed { get; set; }
        public string WindDir { get; set; }
        public int PressureMm { get; set; }
        public int PressurePa { get; set; }
        public int Humidity { get; set; }
        public string Daytime { get; set; }
        public bool Polar { get; set; }
        public string Season { get; set; }
        public string Source { get; set; }
        public double SoilMoisture { get; set; }
        public int SoilTemp { get; set; }
        public int UvIndex { get; set; }
        public double WindGust { get; set; }
    }
}