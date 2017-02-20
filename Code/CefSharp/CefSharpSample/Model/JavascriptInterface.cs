using System.Windows;

namespace CefSharpSample.Model
{
    public class JavascriptInterface
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show("Message from browser: " + message, "System.MessageBox");
        }
    }
}
