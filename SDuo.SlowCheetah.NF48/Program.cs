using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDuo.SlowCheetah.NF48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SlowCheetah:{ConfigurationManager.AppSettings.Get("SlowCheetah")}");
            Console.ReadKey();
        }
    }
}
