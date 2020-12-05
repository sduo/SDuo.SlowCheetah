using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SDuo.SlowCheetah.NF50
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("configuration.xml")
                .Build();

            Console.WriteLine($"SlowCheetah:{config["SlowCheetah"]}");
            Console.ReadKey();
        }
    }
}
