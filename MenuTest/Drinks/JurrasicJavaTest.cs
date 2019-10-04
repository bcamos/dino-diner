/* JurassicJava.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Drinks
{
    /// <summary>
    /// Tests for JurassicJava class
    /// </summary>
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            JurassicJava coffee = new JurassicJava();
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
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(.59, coffee.Price);
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(.99, coffee.Price);
            Assert.Equal<uint>(4, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCalAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
            Assert.Equal<uint>(8, coffee.Calories);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToLeaveSpaceForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Contains<string>("Water", coffee.Ingredients);
            Assert.Contains<string>("Coffee", coffee.Ingredients);
        }
    }
}
