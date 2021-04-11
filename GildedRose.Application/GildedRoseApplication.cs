using GildedRose.Domain.Models.Base;
using GildedRose.Domain.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Application
{
    public class GildedRoseApplication : IRunner
    {
        public void Run()
        {
            Console.WriteLine("OMGHAI!");

            IList<ItemQuality> items = new List<ItemQuality>
            {
                new RegularItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrie {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new RegularItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePasses {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new BackstagePasses {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new BackstagePasses {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
                new Conjured {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                    item.UpdateQuality();
                }

                Console.WriteLine("");
            }
        }
    }
}
