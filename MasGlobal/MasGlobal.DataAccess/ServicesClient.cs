namespace MasGlobal.DataAccess
{
    using System;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;

    /// <summary>
    /// Class ServicesClient.
    /// </summary>
    public class ServicesClient
    {
        /// <summary>
        /// Initialize the urlservice to call.
        /// </summary>
        public string UrlServices { get; set; }

        /// <summary>
        /// Initialize the method name GET.
        /// </summary>
        private string HttpGet => "GET";

        /// <summary>
        /// Initializr ServiceClient Attributes.
        /// </summary>
        /// <param name="url"></param>
        public ServicesClient(string url)
        {
            UrlServices = url;
        }

        /// <summary>
        /// Create WebRequest and initialize headers.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="HttpMethod"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public WebRequest GetWebRequest(string url, string HttpMethod, int timeOut)
        {
            var webRequest = WebRequest.Create(new Uri(url));
            webRequest.Method = HttpMethod;
            webRequest.Timeout = timeOut;
            webRequest.Headers.Add("Content-Type", "Application/json; charset=utf-8");
            webRequest.Headers.Add("Accept-Type", "Application/json; charset=utf-8");

            return webRequest;
        }

        /// <summary>
        /// Execute GET methods.
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="methodName"></param>
        /// <param name="value"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public object Get(string controllerName, string methodName, string value, int timeOut = 90000)
        {
            var entity = default(object);
            var url = $"{UrlServices}/{controllerName}/{methodName}/{value}";

            try
            {
                var request = GetWebRequest(url, HttpGet, timeOut);
                WebResponse response = request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        entity = JsonConvert.DeserializeObject<object>(streamReader.ReadToEnd());
                    }

                }

                return entity;
            }
#pragma warning disable S2737 // "catch" clauses should do more than rethrow
            catch (Exception ex)
            {
                throw;
            }
#pragma warning restore S2737 // "catch" clauses should do more than rethrow
        }
    }
}
