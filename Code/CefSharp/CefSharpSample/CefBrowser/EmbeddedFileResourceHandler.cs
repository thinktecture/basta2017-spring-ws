using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using CefSharp;

namespace CefSharpSample.CefBrowser
{
    public class EmbeddedFileResourceHandler : IResourceHandler
    {
        private static readonly Assembly ResourceAssembly = Assembly.GetExecutingAssembly();
        private static readonly string[] AvailableFiles = ResourceAssembly.GetManifestResourceNames();

        private string mimeType;
        private Stream stream;

        public bool ProcessRequestAsync(IRequest request, ICallback callback)
        {
            // The 'host' portion is entirely ignored by this scheme handler.
            var uri = new Uri(request.Url);
            var fileName = uri.AbsolutePath.Substring(1); // remove starting slash

            var resourceName = "CefSharpSample.EmbeddedResources." + fileName;

            if (AvailableFiles.Contains(resourceName))
            {
                Task.Run(() =>
                {
                    using (callback)
                    {
                        stream = ResourceAssembly.GetManifestResourceStream(resourceName);

                        var fileExtension = Path.GetExtension(fileName);
                        mimeType = ResourceHandler.GetMimeType(fileExtension);

                        callback.Continue();
                    }
                });

                return true;
            }
            else
            {
                callback.Dispose();
            }

            return false;
        }

        public Stream GetResponse(IResponse response, out long responseLength, out string redirectUrl)
        {
            responseLength = stream.Length;
            redirectUrl = null;

            response.StatusCode = (int)HttpStatusCode.OK;
            response.StatusText = "OK";
            response.MimeType = mimeType;

            return stream;
        }
    }
}