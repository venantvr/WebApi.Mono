using System;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Hosting;
using System.Web.Http;
using System.Collections.Generic;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://*:1234";

            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();
            }
        }
    }
}
