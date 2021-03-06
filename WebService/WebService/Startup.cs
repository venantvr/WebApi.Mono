﻿using System.Web.Http;
using Microsoft.Owin;
using Owin;
using WebService;

[assembly: OwinStartup(typeof (Startup))]

namespace WebService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            config.EnableCors();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(config.Formatters.JsonFormatter);

            app.UseWebApi(config);
        }
    }
}