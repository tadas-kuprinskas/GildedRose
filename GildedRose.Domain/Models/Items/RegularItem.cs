using GildedRose.Domain.Interfaces;
using GildedRose.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Items
{
    public class RegularItem : ItemQuality
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality -= SellIn >= 0 ? 1 : 2;

            if (Quality < MinQuality)
                Quality = MinQuality;
        }
    }
}
