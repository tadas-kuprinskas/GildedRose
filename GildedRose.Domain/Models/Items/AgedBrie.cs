using GildedRose.Domain.Interfaces;
using GildedRose.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Items
{
    public class AgedBrie : ItemQuality
    {      
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn >= 0)
                Quality += 1;
            else
                Quality += 2;
           
            if (Quality > 50)
                Quality = MaxQuality;  //quality can't be higher than 50 
        }
    }
}
