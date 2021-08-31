using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaRaspberry.Views
{
    public class EmptyWidgetView : UserControl
    {
        public EmptyWidgetView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}