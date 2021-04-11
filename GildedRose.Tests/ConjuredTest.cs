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
    public class ConjuredTest
    {
        [Theory]
        [InlineData(0, 4, 1, 6)]
        [InlineData(-4, 6, -3, 10)]
        [InlineData(-8, 0, -7, 0)]
        [InlineData(-1, 0, 0, 0)]
        [InlineData(49, 48, 50, 50)]
        public void ConjuredUpdateQuality_GivenSellInAndQuality_ExpectedDataIsCorrect(int expectedSellIn, int expectedQuality, int currentSellIn, int currentQuality)
        {
            Conjured item = new() { Name = "Conjured Mana Cake", SellIn = currentSellIn, Quality = currentQuality };
            item.UpdateQuality();
            item.SellIn.Should().Be(expectedSellIn);
            item.Quality.Should().Be(expectedQuality);
        }
    }
}
