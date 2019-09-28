/* WaterTest.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.MenuTest.Drinks
{
    /// <summary>
    /// Tests for the Water class
    /// </summary>
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
            Assert.Equal<Size>(Size.Small, water.Size);
            Assert.False(water.Lemon);
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            water.Lemon = true;
            Assert.Contains<string>("Lemon", water.Ingredients);
        }
    }
}
