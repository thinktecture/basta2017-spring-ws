using System.Configuration;
using System.Windows;
using CefSharpSample.Model;

namespace CefSharpSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Browser.RegisterAsyncJsObject("appHost", new JavascriptInterface());

            var defaultUrl = ConfigurationManager.AppSettings["defaultUrl"] ?? "http://thinktecture.com";
            DataContext = new MainWindowViewModel(defaultUrl, Browser);
        }
    }
}
