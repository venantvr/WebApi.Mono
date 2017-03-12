using System;
using System.Configuration;
using System.Net;
using FluentScheduler;

namespace WebScheduler
{
    public class MyJob : IJob
    {
        public void Execute()
        {
            var webClient = new WebClient();
            webClient.BaseAddress = ConfigurationManager.AppSettings["UrlToCallEvery2Seconds"];

            try
            {
                var response = webClient.DownloadString(@"api/message");
                Console.WriteLine("Response : " + response);
            }
            catch (WebException ex)
            {
                Console.WriteLine("No response");
            }
        }
    }
}