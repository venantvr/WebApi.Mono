using System;
using Microsoft.Owin.Hosting;

namespace WebService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var baseUrl = "http://*:1234";

            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();
            }
        }
    }
}