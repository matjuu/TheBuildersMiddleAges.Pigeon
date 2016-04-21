using System;
using Microsoft.Owin.Hosting;

namespace TheBuildersMiddleAges.Pigeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://*.8081";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}