using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Serialization;

namespace Test
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            ); 
            var jsonFormater = config.Formatters.JsonFormatter;
            jsonFormater.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            jsonFormater.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            jsonFormater.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


        }
    }
}
