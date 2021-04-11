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
    public class SulfurasTest
    {
        [Theory]
        [InlineData(1, 80, 1, 80)]
        [InlineData(-1, 80, -1, 80)]
        public void SulfurasUpdateQuality_GivenSellInAndQuality_ExpectedDataIsCorrect(int expectedSellIn, int expectedQuality, int currentSellIn, int currentQuality)
        {
            Sulfuras item = new() { Name = "Sulfuras, Hand of Ragnaros", SellIn = currentSellIn, Quality = currentQuality };
            item.UpdateQuality();
            item.SellIn.Should().Be(expectedSellIn);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
