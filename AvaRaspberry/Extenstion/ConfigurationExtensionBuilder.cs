using Avalonia.Controls;

namespace AvaRaspberry.Extenstion
{
    public static class ConfigurationExtensionBuilder
    {
        public static T BuildConfiguration<T>(this T builder) where T : AppBuilderBase<T>, new()
        {
            BuildConfig();

            return builder;
        }
        
        private static void BuildConfig()
            => ConfigurationSingleton.GetInstance();
    }
}