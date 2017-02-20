using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using CefSharp;

namespace CefSharpSample.CefBrowser
{
    public class LocalFileResourceHandler : IResourceHandler
    {
        private string mimeType;
        private Stream stream;

        public bool ProcessRequestAsync(IRequest request, ICallback callback)
        {
            // The 'host' portion is entirely ignored by this scheme handler.
            var uri = new Uri(request.Url);
            var fileName = uri.AbsolutePath;

            var localFilePath = "./LocalFiles" + fileName;

            if (File.Exists(localFilePath))
            {
                Task.Run(() =>
                {
                    using (callback)
                    {
                        stream = File.OpenRead(localFilePath);

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