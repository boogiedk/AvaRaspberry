using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaRaspberry.Views
{
    public class WeatherWidgetView : UserControl
    {
        public WeatherWidgetView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}