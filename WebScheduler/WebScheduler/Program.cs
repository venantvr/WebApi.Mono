using System;
using Microsoft.Owin.Hosting;

namespace WebScheduler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var baseUrl = "http://*:5678";

            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();
            }
        }
    }
}