using System;
using System.Windows;
using CefSharp;
using CefSharpSample.CefBrowser;

namespace CefSharpSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            // initialize CEF
            var cefSettings = new CefSettings();

            cefSettings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = "local",
                SchemeHandlerFactory = new CustomSchemeHandlerfactory(),
            });

            cefSettings.RegisterScheme(new CefCustomScheme()
            {
                SchemeName = "embedded",
                SchemeHandlerFactory = new CustomSchemeHandlerfactory(),
            });

            if (!Cef.Initialize(cefSettings))
            {
                throw new Exception("Unable to Initialize Cef");
            }
        }
    }
}


