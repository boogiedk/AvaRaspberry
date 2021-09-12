using System.Threading.Tasks;
using AvaRaspberry.Models;
using AvaRaspberry.Services;
using ReactiveUI;

namespace AvaRaspberry.ViewModels
{
    public class WeatherWidgetViewModel : ViewModelBase
    {
        private readonly YandexWeatherService _weatherService = new();
        
        private WeatherModel _weatherModel = new("Unknown", 0);

        public WeatherModel WeatherModel
        {
            get => _weatherModel;
            private set => this.RaiseAndSetIfChanged(ref _weatherModel, value);
        }


        public WeatherWidgetViewModel()
        {
            Task.Run(async () => await UpdateForecast());
        }

        private async Task UpdateForecast()
        {
            var yaWeatherResponse = await _weatherService.GetByCoordinate();

            WeatherModel = new WeatherModel(yaWeatherResponse.Info.Tzinfo.Name, yaWeatherResponse.Fact.Temp);
        }
    }
}