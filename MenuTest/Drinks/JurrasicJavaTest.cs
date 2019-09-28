/* JurrasicJava.cs
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
    /// Tests for JurrasicJava class
    /// </summary>
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<double>(.59, coffee.Price);
            Assert.Equal<uint>(2, coffee.Calories);
            Assert.Equal<Size>(Size.Small, coffee.Size);
            Assert.False(coffee.Ice);
            Assert.False(coffee.Decaf);
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(.59, coffee.Price);
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(.99, coffee.Price);
            Assert.Equal<uint>(4, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
            Assert.Equal<uint>(8, coffee.Calories);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToLeaveSpaceForCream()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Contains<string>("Water", coffee.Ingredients);
            Assert.Contains<string>("Coffee", coffee.Ingredients);
        }
    }
}
