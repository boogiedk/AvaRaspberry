using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AvaRaspberry.Models.Integrations.YandexWeather;
using Newtonsoft.Json;

namespace AvaRaspberry.Services
{
    public class YandexWeatherService
    {
        //https://api.weather.yandex.ru/v2/forecast?lat=55.751244&lon=37.618423&[lang=ru_RU]
        private const string ApiGetPathBase = "https://api.weather.yandex.ru/v2/forecast?";
        private const string Token = "094ad216-5c81-4b58-97fd-b582cfb7eea6";
        private const string Local = "ru_RU";
        private const string latitude = "55.751244";
        private const string longitude = "37.618423";

        private readonly HttpClient _http = new();

        public YandexWeatherService()
        {
            ApplyTokenToHeaders(Token);
        }
        
        public async Task<YandexWeatherResponse> GetByCoordinate(string latitude = latitude, string longitude = latitude)
        {
            var path = "https://api.weather.yandex.ru/v2/forecast?lat=55.751244&lon=37.618423&[lang=ru_RU]"; //GetYandexWeatherUrl(latitude, longitude);
            using var response = await _http.GetAsync(path).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var content = JsonConvert.DeserializeObject<YandexWeatherResponse>(json) ?? new YandexWeatherResponse();

            return content;
        }
        
        private Uri GetYandexWeatherUrl(string latitude, string longitude)
        {
            var uri = ApiGetPathBase + $"lat={latitude}&lon={longitude}&[lang={Local}]";
            return new Uri(uri);
        } 
        
        private void ApplyTokenToHeaders(string token)
        {
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _http.DefaultRequestHeaders.Add("X-Yandex-API-Key",token);
        }
    }
}