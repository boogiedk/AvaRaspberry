using Microsoft.Extensions.Configuration;

namespace AvaRaspberry.Extenstion
{
    public class ConfigurationSingleton
    {
        private ConfigurationSingleton()
        {
        }

        private static ConfigurationSingleton _instance;

        public static ConfigurationSingleton GetInstance()
        {
            if (_instance != null) return _instance;
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            _instance = new ConfigurationSingleton()
            {
                Widgets = configuration.GetSection("Widgets").Get<Widgets>()
            };

            return _instance;
        }

        public Widgets Widgets { get; set; }
    }
}