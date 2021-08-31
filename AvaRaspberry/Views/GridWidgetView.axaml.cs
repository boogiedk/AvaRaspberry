using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaRaspberry.Views
{
    public class GridWidgetView : UserControl
    {
        public GridWidgetView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}