using GildedRose.Domain.Interfaces;
using GildedRose.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Items
{
    public class Conjured : ItemQuality
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality -= SellIn >= 0 ? 2 : 4;

            if (Quality < MinQuality)
                Quality = MinQuality;
        }
    }
}
