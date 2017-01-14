using System;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Hosting;
using System.Web.Http;
using System.Collections.Generic;

[assembly: OwinStartup(typeof(WebService.Startup))]
namespace WebService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration(); 
            config.Routes.MapHttpRoute(
                name: "DefaultApi", 
                routeTemplate: "api/{controller}/{id}", 
                defaults: new { id = RouteParameter.Optional } 
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(config.Formatters.JsonFormatter);

            app.UseWebApi(config); 
        }
    }
}

