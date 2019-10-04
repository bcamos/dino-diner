/** Menu.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Menu represents the menu of the DinoDiner
    /// </summary>
    public class Menu
    {
        // Which drinks are on the menu
        private bool hasJurassicJava = true;
        private bool hasSodasaurus = true;
        private bool hasTyrannotea = true;
        private bool hasWater = true;

        // Which Entrees are on the menu
        private bool hasBrontowurst = true;
        private bool hasDinoNuggets = true;
        private bool hasPrehistoricPBJ = true;
        private bool hasPterodactylWings = true;
        private bool hasSteakosaurusBurger = true;
        private bool hasTRexKingBurger = true;
        private bool hasVelociWrap = true;

        //Which Sides are on the menu
        private bool hasFryceritops = true;
        private bool hasMeteorMacAndCheese = true;
        private bool hasMezzorellaSticks = true;
        private bool hasTriceritots = true;

        /// <summary>
        /// A list of the menu items in the menu
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menu = new List<IMenuItem>();
                foreach(Entree e in AvailableEntrees)
                {
                    menu.Add(e);
                }
                foreach(Drink d in AvailableDrinks)
                {
                    menu.Add(d);
                }
                foreach(Side s in AvailableSides)
                {
                    menu.Add(s);
                }
                foreach(CretaceousCombo c in AvailableCombos)
                {
                    menu.Add(c);
                }
                return menu;
            }            
        }

        /// <summary>
        /// A list of all the entrees in the menu
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entrees = new List<Entree>();
                if (hasBrontowurst) entrees.Add(new Brontowurst());
                if (hasDinoNuggets) entrees.Add(new DinoNuggets());
                if (hasPrehistoricPBJ) entrees.Add(new PrehistoricPBJ());
                if (hasPterodactylWings) entrees.Add(new PterodactylWings());
                if (hasSteakosaurusBurger) entrees.Add(new SteakosaurusBurger());
                if (hasTRexKingBurger) entrees.Add(new TRexKingBurger());
                if (hasVelociWrap) entrees.Add(new VelociWrap());
                return entrees;
            }
        }

        /// <summary>
        /// A list of all the drinks in the menu
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinks = new List<Drink>();
                if (hasJurassicJava) drinks.Add(new JurassicJava());
                if (hasSodasaurus) drinks.Add(new Sodasaurus());
                if (hasTyrannotea) drinks.Add(new Tyrannotea());
                if (hasWater) drinks.Add(new Water());
                return drinks;
            }
        }

        /// <summary>
        /// A list of all available sides in the menu
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> sides = new List<Side>();
                if (hasFryceritops) sides.Add(new Fryceritops());
                if (hasMeteorMacAndCheese) sides.Add(new MeteorMacAndCheese());
                if (hasMezzorellaSticks) sides.Add(new MezzorellaSticks());
                if (hasTriceritots) sides.Add(new Triceritots());
                return sides;
            }
        }

        /// <summary>
        /// A list of all available combos in the menu
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();
                if (hasBrontowurst) combos.Add(new CretaceousCombo(new Brontowurst()));
                if (hasDinoNuggets) combos.Add(new CretaceousCombo(new DinoNuggets()));
                if (hasPrehistoricPBJ) combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                if (hasPterodactylWings) combos.Add(new CretaceousCombo(new PterodactylWings()));
                if (hasSteakosaurusBurger) combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                if (hasTRexKingBurger) combos.Add(new CretaceousCombo(new TRexKingBurger()));
                if (hasVelociWrap) combos.Add(new CretaceousCombo(new VelociWrap()));
                return combos;
            }
        }

        /// <summary>
        /// Returns the names of all the menu items in the menu
        /// </summary>
        /// <returns>The names of all the menu items in the menu</returns>
        public override string ToString()
        {
            List <IMenuItem> menuItems = AvailableMenuItems;
            string menu = "";
            foreach(IMenuItem i in menuItems)
            {
                menu += i.ToString() + "\n";
            }
            return menu;
        }
    }
}
