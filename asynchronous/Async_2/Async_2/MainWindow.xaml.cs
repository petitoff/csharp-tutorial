using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace Async_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var html = await GetHtmlAsync("http://google.com");
            MessageBox.Show(html.Substring(0,10));
        }

    }
}
