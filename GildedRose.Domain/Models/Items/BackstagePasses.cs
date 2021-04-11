using GildedRose.Domain.Interfaces;
using GildedRose.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Items
{
    public class BackstagePasses : ItemQuality
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn >= 0)
            {
                if (SellIn >= 5)
                {
                    Quality += SellIn > 10 ? 1 : 2;
                }
                else
                {
                    Quality += 3;
                }
            }
            else
            {
                Quality = MinQuality;
            }

            if (Quality > MaxQuality)
                Quality = MaxQuality;
        }
    }
}
