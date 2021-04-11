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
    public class BackstagePassesTest
    {
        [Theory]
        [InlineData(-2, 0, -1, 50)]
        [InlineData(10, 30, 11, 28)]
        [InlineData(1, 47, 2, 44)]
        [InlineData(6, 33, 7, 31)]
        public void BackstagePassesUpdateQuality_GivenSellInAndQuality_ExpectedDataIsCorrect(int expectedSellIn, int expectedQuality, int currentSellIn, int currentQuality)
        {
            BackstagePasses item = new() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = currentSellIn, Quality = currentQuality };
            item.UpdateQuality();
            item.SellIn.Should().Be(expectedSellIn);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
