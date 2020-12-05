using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace SDuo.SlowCheetah.NC31
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            Console.WriteLine($"SlowCheetah:{config["SlowCheetah"]}");
            Console.ReadKey();
        }
    }
}
