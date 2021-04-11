using System;
using Microsoft.Extensions.DependencyInjection;

namespace GildedRose.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = DependencyInjection.ConfigureServices();

            var application = serviceProvider.GetService<IRunner>();
            application.Run();
        }
    }
}
