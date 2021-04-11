using GildedRose.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Items
{
    public class Sulfuras : ItemQuality
    {
        public override void UpdateQuality()
        {
            Quality = 80;
        }
    }
}
