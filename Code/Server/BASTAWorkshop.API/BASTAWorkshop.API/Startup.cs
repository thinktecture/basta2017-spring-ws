using Newtonsoft.Json.Serialization;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BASTAWorkshop.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            // TODO: erm...
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}");

            var formatter = new JsonMediaTypeFormatter();
            formatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Formatters.Clear();
            config.Formatters.Add(formatter);

            config.EnableSwagger(c =>
             {
                 c.SingleApiVersion("v1", "BASTA Spring 2017 Workshop API");
             }).EnableSwaggerUi();
            
            app.UseWebApi(config);
        }
    }
}