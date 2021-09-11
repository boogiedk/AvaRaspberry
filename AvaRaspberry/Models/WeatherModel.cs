namespace AvaRaspberry.Models
{
    public class WeatherModel
    {
        public WeatherModel(string city, int temperature)
        {
            City = city;
            Temperature = temperature;
        }

        public string City { get; set; }
        public int Temperature { get; set; }
        
        public string DisplayTemperature => Temperature + " ° C";
    }
}