using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Application
{
    public static class DependencyInjection
    {
        public static ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<IRunner, GildedRoseApplication>()
                .BuildServiceProvider();
        }
    }
}
