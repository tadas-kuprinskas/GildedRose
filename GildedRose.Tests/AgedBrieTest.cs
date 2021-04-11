using FluentAssertions;
using GildedRose.Domain.Models.Base;
using GildedRose.Domain.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieTest
    {
        [Theory]
        [InlineData(-6, 50, -5, 50)]
        [InlineData(1, 1, 2, 0)]
        [InlineData(-1, 12, 0, 10)]
        [InlineData(-1, 30, 0, 28)]
        public void AgedBrieUpdateQuality_GivenSellInAndQuality_ExpectedDataIsCorrect(int expectedSellIn, int expectedQuality, int currentSellIn, int currentQuality)
        {
            AgedBrie item = new() { Name = "Aged Brie", SellIn = currentSellIn, Quality = currentQuality };
            item.UpdateQuality();
            item.SellIn.Should().Be(expectedSellIn);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
