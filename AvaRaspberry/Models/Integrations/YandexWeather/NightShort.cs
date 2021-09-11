﻿namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class NightShort
    {
        public string Source { get; set; }
        public int Temp { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public string WindDir { get; set; }
        public int PressureMm { get; set; }
        public int PressurePa { get; set; }
        public int Humidity { get; set; }
        public int SoilTemp { get; set; }
        public double SoilMoisture { get; set; }
        public double PrecMm { get; set; }
        public int PrecProb { get; set; }
        public int PrecPeriod { get; set; }
        public double Cloudness { get; set; }
        public int PrecType { get; set; }
        public double PrecStrength { get; set; }
        public string Icon { get; set; }
        public string Condition { get; set; }
        public int UvIndex { get; set; }
        public int FeelsLike { get; set; }
        public string Daytime { get; set; }
        public bool Polar { get; set; }
    }
}