using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace AvaRaspberry.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Cursor = new Cursor(StandardCursorType.None);
            
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}