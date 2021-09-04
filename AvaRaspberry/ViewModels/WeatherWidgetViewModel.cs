using AvaRaspberry.Models;

namespace AvaRaspberry.ViewModels
{
    public class WeatherWidgetViewModel : ViewModelBase
    {
        public WeatherModel Weather { get; set; } 

        public WeatherWidgetViewModel()
        {
            Weather = new WeatherModel("Moscow", 18);
        }
    }
}