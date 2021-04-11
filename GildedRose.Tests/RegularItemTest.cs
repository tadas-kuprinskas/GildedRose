using FluentAssertions;
using GildedRose.Domain.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRose.Tests
{
    public class RegularItemTest
    {
        [Theory]
        [InlineData(7, 16, 8, 17)]
        [InlineData(-1, 8, 0, 10)]
        [InlineData(-19, 0, -18, 0)]
        public void RegularItemUpdateQuality_GivenSellInAndQuality_ExpectedDataIsCorrect(int expectedSellIn, int expectedQuality, int currentSellIn, int currentQuality)
        {
            RegularItem item = new() { Name = "+5 Dexterity Vest", SellIn = currentSellIn, Quality = currentQuality };
            item.UpdateQuality();
            item.SellIn.Should().Be(expectedSellIn);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
