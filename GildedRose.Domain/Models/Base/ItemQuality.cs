using GildedRose.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Domain.Models.Base
{
    public abstract class ItemQuality : Item, IUpdateQuality
    {

        public int MinQuality { get; set; } = 0;
        public int MaxQuality { get; set; } = 50;
        public abstract void UpdateQuality();       
    }
}
