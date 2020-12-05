using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SDuo.SlowCheetah.NC21
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
