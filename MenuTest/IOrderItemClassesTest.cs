/** IOrderItemClassesTest.cs
 * Author: Ben Amos
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class IOrderItemClassesTest
    {
        #region Entrees

        [Fact]
        public void BrontowurstDescriptionShouldGiveName()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void BrontowurstSpecialShouldBeEmptyByDefault()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }

        [Fact]
        public void BrontowurstShouldGiveCorrectArrayForSingleSpecial()
        {
            Brontowurst b1 = new Brontowurst();
            Brontowurst b2 = new Brontowurst();
            Brontowurst b3 = new Brontowurst();

            b1.HoldBun();
            Assert.Contains<string>("Hold Bun", b1.Special);

            b2.HoldOnion();
            Assert.Contains<string>("Hold Onion", b2.Special);

            b3.HoldPeppers();
            Assert.Contains<string>("Hold Peppers", b3.Special);
        }

        [Fact]
        public void BrontowurstShouldGiveCorrectArrayForTwoSpecials()
        {
            Brontowurst b1 = new Brontowurst();
            Brontowurst b2 = new Brontowurst();
            Brontowurst b3 = new Brontowurst();

            b1.HoldBun();
            b1.HoldOnion();
            Assert.Contains<string>("Hold Bun", b1.Special);
            Assert.Contains<string>("Hold Onion", b1.Special);

            b2.HoldBun();
            b2.HoldPeppers();
            Assert.Contains<string>("Hold Bun", b2.Special);
            Assert.Contains<string>("Hold Peppers", b2.Special);

            b3.HoldOnion();
            b3.HoldPeppers();
            Assert.Contains<string>("Hold Onion", b3.Special);
            Assert.Contains<string>("Hold Peppers", b3.Special);
        }

        [Fact]
        public void BrontowurstShouldGiveCorrectArrayForThreeSpecials()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldOnion();
            b.HoldPeppers();
            Assert.Contains<string>("Hold Bun", b.Special);
            Assert.Contains<string>("Hold Onion", b.Special);
            Assert.Contains<string>("Hold Peppers", b.Special);
        }

        [Fact]
        public void DinoNuggetDescriptionShouldGiveName()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }

        [Fact]
        public void DinoNuggetsSpecialShouldBeEmptyByDefault()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);
        }

        [Fact]
        public void DinoNuggetsSpecialShouldGiveCorrectArrayForAddingNuggets()
        {
            DinoNuggets dn = new DinoNuggets();
            for(int i = 1; i <= 6; i++)
            {
                dn.AddNugget();
                Assert.Contains<string>($"{i} Extra Nuggets", dn.Special);
            }
        }

        [Fact]
        public void PrehistoricSpecialShouldBeEmptyByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void PrehistoricPBJDescriptionShouldGiveName()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void PrehistoricPBJSpecialShouldGiveCorrectArrayForSpecials()
        {
            PrehistoricPBJ pbj1 = new PrehistoricPBJ();
            PrehistoricPBJ pbj2 = new PrehistoricPBJ();
            PrehistoricPBJ pbj3 = new PrehistoricPBJ();

            pbj1.HoldJelly();
            Assert.Contains<string>("Hold Jelly", pbj1.Special);

            pbj2.HoldPeanutButter();
            Assert.Contains<string>("Hold Peanut Butter", pbj2.Special);

            pbj3.HoldJelly();
            pbj3.HoldPeanutButter();
            Assert.Contains<string>("Hold Jelly", pbj3.Special);
            Assert.Contains<string>("Hold Peanut Butter", pbj3.Special);
        }

        [Fact]
        public void PterodactylWingsDescriptionShouldGiveName()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void PterodactylSpecialShouldBeEmptyByDefault()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionShouldGiveName()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void SteakosaurusSpecialShouldBeEmptyByDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerSpecialShouldGiveCorrectArrayForSingleSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.Contains<string>("Hold Bun", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Pickle", sb.Special);
        }

        [Fact]
        public void SteakosaurusBurgerSpecialShouldGiveCorrectArrayForTwoSpecials()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldMustard();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Mustard", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);
        }

        [Fact]
        public void SteakosaurusSpecialShouldGiveCorrectArrayForThreeSpecials()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldPickle();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);

            sb = new SteakosaurusBurger();
            sb.HoldPickle();
            sb.HoldKetchup();
            sb.HoldMustard();
            Assert.Contains<string>("Hold Pickle", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);
        }

        [Fact]
        public void SteakosaurusSpecialShouldGiveCorrectArrayForFourSpecials()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldKetchup();
            sb.HoldMustard();
            sb.HoldPickle();
            Assert.Contains<string>("Hold Bun", sb.Special);
            Assert.Contains<string>("Hold Ketchup", sb.Special);
            Assert.Contains<string>("Hold Mustard", sb.Special);
            Assert.Contains<string>("Hold Pickle", sb.Special);
        }

        [Fact]
        public void TRexKingBurgerDescriptionShouldGiveName()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void TRexSpecialShouldBeEmptyByDefault()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.Empty(tb.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForSingleSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            Assert.Contains<string>("Hold Bun", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldKetchup();
            Assert.Contains<string>("Hold Ketchup", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMayo();
            Assert.Contains<string>("Hold Mayo", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            Assert.Contains<string>("Hold Mustard", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldOnion();
            Assert.Contains<string>("Hold Onion", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldPickle();
            Assert.Contains<string>("Hold Pickle", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldTomato();
            Assert.Contains<string>("Hold Tomato", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForTwoSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldPickle();
            tr.HoldTomato();
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForThreeSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            tr.HoldTomato();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldPickle();
            tr.HoldTomato();
            tr.HoldLettuce();
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForFourSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            tr.HoldLettuce();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            tr.HoldTomato();
            tr.HoldPickle();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldPickle();
            tr.HoldTomato();
            tr.HoldLettuce();
            tr.HoldBun();
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Bun", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForFiveSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            tr.HoldLettuce();
            tr.HoldMayo();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Mayo", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            tr.HoldTomato();
            tr.HoldPickle();
            tr.HoldBun();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Bun", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldPickle();
            tr.HoldTomato();
            tr.HoldLettuce();
            tr.HoldBun();
            tr.HoldOnion();
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForSixSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            tr.HoldLettuce();
            tr.HoldMayo();
            tr.HoldPickle();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Mayo", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            tr.HoldTomato();
            tr.HoldPickle();
            tr.HoldBun();
            tr.HoldLettuce();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForSevenSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            tr.HoldLettuce();
            tr.HoldMayo();
            tr.HoldPickle();
            tr.HoldMustard();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Mayo", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Mustard", tr.Special);

            tr = new TRexKingBurger();
            tr.HoldMustard();
            tr.HoldKetchup();
            tr.HoldTomato();
            tr.HoldPickle();
            tr.HoldBun();
            tr.HoldLettuce();
            tr.HoldMayo();
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Mayo", tr.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialShouldGiveCorrectArrayForEightSpecials()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            tr.HoldKetchup();
            tr.HoldOnion();
            tr.HoldLettuce();
            tr.HoldMayo();
            tr.HoldPickle();
            tr.HoldMustard();
            tr.HoldTomato();
            Assert.Contains<string>("Hold Bun", tr.Special);
            Assert.Contains<string>("Hold Ketchup", tr.Special);
            Assert.Contains<string>("Hold Onion", tr.Special);
            Assert.Contains<string>("Hold Lettuce", tr.Special);
            Assert.Contains<string>("Hold Mayo", tr.Special);
            Assert.Contains<string>("Hold Pickle", tr.Special);
            Assert.Contains<string>("Hold Mustard", tr.Special);
            Assert.Contains<string>("Hold Tomato", tr.Special);
        }

        [Fact]
        public void VelociSpecialShouldBeEmptyByDefault()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void VelociWrapDescriptionShouldGiveName()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        [Fact]
        public void VelociWrapSpecialShouldGiveCorrectArrayForSingleSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.Contains<string>("Hold Cheese", v.Special);

            v = new VelociWrap();
            v.HoldDressing();
            Assert.Contains<string>("Hold Dressing", v.Special);

            v = new VelociWrap();
            v.HoldLettuce();
            Assert.Contains<string>("Hold Lettuce", v.Special);
        }

        [Fact]
        public void VelociWrapSpecialShouldGiveCorrectArrayForTwoSpecials()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            v.HoldDressing();
            Assert.Contains<string>("Hold Cheese", v.Special);
            Assert.Contains<string>("Hold Dressing", v.Special);

            v = new VelociWrap();
            v.HoldCheese();
            v.HoldLettuce();
            Assert.Contains<string>("Hold Cheese", v.Special);
            Assert.Contains<string>("Hold Lettuce", v.Special);

            v = new VelociWrap();
            v.HoldDressing();
            v.HoldLettuce();
            Assert.Contains<string>("Hold Dressing", v.Special);
            Assert.Contains<string>("Hold Lettuce", v.Special);
        }

        [Fact]
        public void VelociWrapSpecialShouldGiveCorrectArrayForThreeSpecials()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            v.HoldDressing();
            v.HoldLettuce();
            Assert.Contains<string>("Hold Cheese", v.Special);
            Assert.Contains<string>("Hold Dressing", v.Special);
            Assert.Contains<string>("Hold Lettuce", v.Special);
        }


        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Fact]
        public void FryceritopsSpecialShouldBeEmptyByDefault()
        {
            Fryceritops f = new Fryceritops();
            Assert.Empty(f.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionShouldGiveNameForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.Description);
        }

        [Fact]
        public void MeteorMacAndCheeseSpecialShouldBeEmptyByDefault()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Empty(mmc.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionShouldGiveNameForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.Description);
        }

        [Fact]
        public void MezzorellaSticksSpecialShouldBeEmptyByDefault()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Empty(ms.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void TriceritotsDescriptionShouldGiveNameForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.Description);
        }

        [Fact]
        public void TriceritotsSpecialShouldBeEmptyByDefault()
        {
            Triceritots t = new Triceritots();
            Assert.Empty(t.Special);
        }

        #endregion

        #region Drinks

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurassicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }

        [Fact]
        public void JurassicJavaSpecialShouldBeEmptyByDefault()
        {
            JurassicJava j = new JurassicJava();
            Assert.Empty(j.Special);
        }

        [Fact]
        public void JurassicJavaSpecialShouldGiveCorrectArrayForSpecials()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.Contains<string>("Add Ice", j.Special);

            j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.Contains<string>("Leave Room For Cream", j.Special);

            j = new JurassicJava();
            j.AddIce();
            j.LeaveRoomForCream();
            Assert.Contains<string>("Leave Room For Cream", j.Special);            
            Assert.Contains<string>("Add Ice", j.Special);
        }


        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodasaurusDescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SodasaurusSpecialShouldBeEmptyByDefault()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void SodasaurusSpecialShouldGiveCorrectArrayForSpecial()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.Contains<string>("Hold Ice", s.Special);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoteaDescriptionShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void TyrannoteaSpecialShouldBeEmptyByDefault()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void TyrannoteaSpecialShouldGiveCorrectArrayForSpecials()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Contains<string>("Add Lemon", t.Special);

            t = new Tyrannotea();
            t.HoldIce();
            Assert.Contains<string>("Hold Ice", t.Special);

            t = new Tyrannotea();
            t.AddLemon();
            t.HoldIce();
            Assert.Contains<string>("Hold Ice", t.Special);            
            Assert.Contains<string>("Add Lemon", t.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        [Fact]
        public void WaterSpecialShouldBeEmptyByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void WaterSpecialShouldGiveCorrectArrayForSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Contains<string>("Hold Ice", w.Special);

            w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Add Lemon", w.Special);

            w = new Water();
            w.HoldIce();
            w.AddLemon();
            Assert.Contains<string>("Hold Ice", w.Special);
            Assert.Contains<string>("Add Lemon", w.Special);
        }

        #endregion

        #region Combos

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void CombosDescriptionShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        [Fact]
        public void ComboSpecialShouldOnlyReturnSideAndDrinkDescription()
        {
            CretaceousCombo c = new CretaceousCombo(new PrehistoricPBJ());
            Assert.Contains(c.Side.Description, c.Special[0]);
            Assert.Contains(c.Drink.Description, c.Special[1]);
        }

        [Fact]
        public void DinoComboSpecialShouldGiveCorrectArrayForSpecial()
        {
            DinoNuggets d = new DinoNuggets();
            JurassicJava j = new JurassicJava();
            CretaceousCombo c = new CretaceousCombo(d);
            c.Drink = j;
            
            j.AddIce();
            d.AddNugget();
            
            Assert.Contains("1 Extra Nuggets", c.Special[0]);
            Assert.Contains(c.Side.Description, c.Special[1]);
            Assert.Contains(j.Description, c.Special[2]);
            Assert.Contains("Add Ice", c.Special[3]);
        }

        [Fact]
        public void BrontoComboSpecialShouldGiveCorrectArrayForSpecial()
        {
            Brontowurst b = new Brontowurst();
            Drink d = new Sodasaurus();
            CretaceousCombo c = new CretaceousCombo(b);
            c.Drink = d;

            b.HoldBun();
            b.HoldOnion();
            d.HoldIce();

            Assert.Contains<string>("Hold Bun", c.Special);
            Assert.Contains<string>("Hold Onion", c.Special);
            Assert.Contains(c.Side.Description, c.Special[2]);
            Assert.Contains(d.Description, c.Special[3]);
            Assert.Contains("Hold Ice", c.Special[4]);
        }        

        #endregion
    }
}
