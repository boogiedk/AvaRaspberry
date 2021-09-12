using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AvaRaspberry.Extenstion;
using AvaRaspberry.Models.Integrations.YandexWeather;
using Newtonsoft.Json;

namespace AvaRaspberry.Services
{
    public class YandexWeatherService
    {
        //https://api.weather.yandex.ru/v2/forecast?lat=55.751244&lon=37.618423&[lang=ru_RU]
        private const string ApiGetPathBase = "https://api.weather.yandex.ru/v2/forecast?";
        private const string Local = "ru_RU";
        private const string Latitude = "55.751244";
        private const string Longitude = "37.618423";

        private readonly HttpClient _http = new();

        private string YandexWeatherApiToken =>
            ConfigurationSingleton.GetInstance().Widgets.Weather.YandexWeather.ApiToken;
        
        private Uri YandexWeatherUrl(string lat, string lon) =>
            new (ApiGetPathBase + $"lat={lat}&lon={lon}&[lang={Local}]");

        public YandexWeatherService()
        {
            ApplyTokenToHeaders(YandexWeatherApiToken);
        }

        public async Task<YandexWeatherResponse> GetByCoordinate(string lat = Latitude, string lon = Longitude)
        {
            var path = YandexWeatherUrl(lat, lon);
            using var response = await _http.GetAsync(path).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var content = JsonConvert.DeserializeObject<YandexWeatherResponse>(json)
                          ?? new YandexWeatherResponse();

            return content;
        }

        private void ApplyTokenToHeaders(string token)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _http.DefaultRequestHeaders.Add("X-Yandex-API-Key",token);
        }
    }
}