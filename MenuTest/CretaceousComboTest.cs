using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        [Fact]
        public void ChangingDrinkAndSideShouldNotifyPropertyChangeSpecialAndPrice()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Drink = new JurassicJava();
            });

            c = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = new JurassicJava();
            });

            c = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Side = new MezzorellaSticks();
            });

            c = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new MezzorellaSticks();
            });
        }
    }
}
