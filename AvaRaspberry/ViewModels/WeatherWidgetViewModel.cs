using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
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
            Task.Run(async () => { await UpdateForecast(); });
        }

        private async Task UpdateForecast()
        {
            var yaWeatherResponse = await _weatherService.GetByCoordinate();

            WeatherModel = new WeatherModel(yaWeatherResponse.Info.Tzinfo.Name, yaWeatherResponse.Fact.Temp);
        }
    }
}