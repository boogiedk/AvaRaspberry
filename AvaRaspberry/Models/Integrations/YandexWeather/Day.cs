﻿namespace AvaRaspberry.Models.Integrations.YandexWeather
{
    public class Day
    {
        public string Source { get; set; }
        public int TempMin { get; set; }
        public int TempAvg { get; set; }
        public int TempMax { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public string WindDir { get; set; }
        public int PressureMm { get; set; }
        public int PressurePa { get; set; }
        public int Humidity { get; set; }
        public int SoilTemp { get; set; }
        public double SoilMoisture { get; set; }
        public int PrecMm { get; set; }
        public int PrecProb { get; set; }
        public int PrecPeriod { get; set; }
        public double Cloudness { get; set; }
        public int PrecType { get; set; }
        public int PrecStrength { get; set; }
        public string Icon { get; set; }
        public string Condition { get; set; }
        public int UvIndex { get; set; }
        public int FeelsLike { get; set; }
        public string Daytime { get; set; }
        public bool Polar { get; set; }
    }
}