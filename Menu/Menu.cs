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
        /// Gets a list of all available ingredients in all menu items
        /// </summary>
        public List<string> AvailableIngredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                foreach(Entree entree in AvailableEntrees)
                {
                    foreach(string ingredient in entree.Ingredients)
                    {
                        if(!ingredients.Contains(ingredient))
                        {
                            ingredients.Add(ingredient);
                        }
                    }
                }
                foreach (Drink drink in AvailableDrinks)
                {
                    foreach (string ingredient in drink.Ingredients)
                    {
                        if (!ingredients.Contains(ingredient))
                        {
                            ingredients.Add(ingredient);
                        }
                    }
                }
                foreach (Side side in AvailableSides)
                {
                    foreach (string ingredient in side.Ingredients)
                    {
                        if (!ingredients.Contains(ingredient))
                        {
                            ingredients.Add(ingredient);
                        }
                    }
                }
                return ingredients;
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

        /// <summary>
        /// Filters a given list of menu items by the menu item's name
        /// </summary>
        /// <param name="menuItems">The list of items to filter</param>
        /// <param name="search">the string to filter on</param>
        /// <returns></returns>
        public static List<CretaceousCombo> FilterByName(List<CretaceousCombo> menuItems, string search)
        {
            List<CretaceousCombo> newList = new List<CretaceousCombo>();
            if(menuItems != null)
            {
                foreach (CretaceousCombo item in menuItems)
                {
                    if (item.ToString().Contains(search))
                    {
                        newList.Add(item);
                    }
                }
            }            
            return newList;
        }

        /// <summary>
        /// Filters a given list of menu items by the menu item's name
        /// </summary>
        /// <param name="menuItems">The list of items to filter</param>
        /// <param name="search">the string to filter on</param>
        /// <returns></returns>
        public static List<Entree> FilterByName(List<Entree> menuItems, string search)
        {
            List<Entree> newList = new List<Entree>();
            if(menuItems != null)
            {
                foreach (Entree item in menuItems)
                {
                    if (item.ToString().Contains(search))
                    {
                        newList.Add(item);
                    }
                }
            }            
            return newList;
        }

        /// <summary>
        /// Filters a given list of menu items by the menu item's name
        /// </summary>
        /// <param name="menuItems">The list of items to filter</param>
        /// <param name="search">the string to filter on</param>
        /// <returns></returns>
        public static List<Drink> FilterByName(List<Drink> menuItems, string search)
        {
            List<Drink> newList = new List<Drink>();
            if(menuItems != null)
            {
                foreach (Drink item in menuItems)
                {
                    if (item.ToString().Contains(search))
                    {
                        newList.Add(item);
                    }
                }
            }            
            return newList;
        }

        /// <summary>
        /// Filters a given list of menu items by the menu item's name
        /// </summary>
        /// <param name="menuItems">The list of items to filter</param>
        /// <param name="search">the string to filter on</param>
        /// <returns></returns>
        public static List<Side> FilterByName(List<Side> menuItems, string search)
        {
            List<Side> newList = new List<Side>();
            if(menuItems != null)
            {
                foreach (Side item in menuItems)
                {
                    if (item.ToString().Contains(search))
                    {
                        newList.Add(item);
                    }
                }
            }            
            return newList;
        }

        /// <summary>
        /// Filters list removing all items less than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="minPrice">The minumum price to filter on</param>
        /// <returns></returns>
        public static List<CretaceousCombo> FilterByMinPrice(List<CretaceousCombo> menuItems, float minPrice)
        {
            List<CretaceousCombo> newList = new List<CretaceousCombo>();
            foreach(CretaceousCombo item in menuItems)
            {
                if(item.Price >= minPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items less than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="minPrice">The minumum price to filter on</param>
        /// <returns></returns>
        public static List<Entree> FilterByMinPrice(List<Entree> menuItems, float minPrice)
        {
            List<Entree> newList = new List<Entree>();
            foreach (Entree item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items less than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="minPrice">The minumum price to filter on</param>
        /// <returns></returns>
        public static List<Side> FilterByMinPrice(List<Side> menuItems, float minPrice)
        {
            List<Side> newList = new List<Side>();
            foreach (Side item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items less than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="minPrice">The minumum price to filter on</param>
        /// <returns></returns>
        public static List<Drink> FilterByMinPrice(List<Drink> menuItems, float minPrice)
        {
            List<Drink> newList = new List<Drink>();
            foreach (Drink item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items more than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="maxPrice">The maximum price to filter on</param>
        /// <returns></returns>
        public static List<CretaceousCombo> FilterByMaxPrice(List<CretaceousCombo> menuItems, float maxPrice)
        {
            List<CretaceousCombo> newList = new List<CretaceousCombo>();
            foreach (CretaceousCombo item in menuItems)
            {
                if (item.Price <= maxPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items more than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="maxPrice">The maximum price to filter on</param>
        /// <returns></returns>
        public static List<Entree> FilterByMaxPrice(List<Entree> menuItems, float maxPrice)
        {
            List<Entree> newList = new List<Entree>();
            foreach (Entree item in menuItems)
            {
                if (item.Price <= maxPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items more than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="maxPrice">The maximum price to filter on</param>
        /// <returns></returns>
        public static List<Side> FilterByMaxPrice(List<Side> menuItems, float maxPrice)
        {
            List<Side> newList = new List<Side>();
            foreach (Side item in menuItems)
            {
                if (item.Price <= maxPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters list removing all items more than the minimum price
        /// </summary>
        /// <param name="menuItems">The list to filter on</param>
        /// <param name="maxPrice">The maximum price to filter on</param>
        /// <returns></returns>
        public static List<Drink> FilterByMaxPrice(List<Drink> menuItems, float maxPrice)
        {
            List<Drink> newList = new List<Drink>();
            foreach (Drink item in menuItems)
            {
                if (item.Price <= maxPrice)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters all menu items out which contain any of the ingredients
        /// </summary>
        /// <param name="menuItems">The menu items to filter on</param>
        /// <param name="ingredients">The ingredients to check</param>
        /// <returns></returns>
        public static List<CretaceousCombo> FilterByIngredients(List<CretaceousCombo> menuItems, List<string> ingredients)
        {
            List<CretaceousCombo> newList = new List<CretaceousCombo>();
            foreach(CretaceousCombo item in menuItems)
            {
                bool add = true;
                foreach(string ingredient in ingredients)
                {
                    if(item.Ingredients.Contains(ingredient))
                    {
                        add = false;
                    }
                }
                if(add)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters all menu items out which contain any of the ingredients
        /// </summary>
        /// <param name="menuItems">The menu items to filter on</param>
        /// <param name="ingredients">The ingredients to check</param>
        /// <returns></returns>
        public static List<Entree> FilterByIngredients(List<Entree> menuItems, List<string> ingredients)
        {
            List<Entree> newList = new List<Entree>();
            foreach (Entree item in menuItems)
            {
                bool add = true;
                foreach (string ingredient in ingredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        add = false;
                    }
                }
                if (add)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters all menu items out which contain any of the ingredients
        /// </summary>
        /// <param name="menuItems">The menu items to filter on</param>
        /// <param name="ingredients">The ingredients to check</param>
        /// <returns></returns>
        public static List<Drink> FilterByIngredients(List<Drink> menuItems, List<string> ingredients)
        {
            List<Drink> newList = new List<Drink>();
            foreach (Drink item in menuItems)
            {
                bool add = true;
                foreach (string ingredient in ingredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        add = false;
                    }
                }
                if (add)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        /// <summary>
        /// Filters all menu items out which contain any of the ingredients
        /// </summary>
        /// <param name="menuItems">The menu items to filter on</param>
        /// <param name="ingredients">The ingredients to check</param>
        /// <returns></returns>
        public static List<Side> FilterByIngredients(List<Side> menuItems, List<string> ingredients)
        {
            List<Side> newList = new List<Side>();
            foreach (Side item in menuItems)
            {
                bool add = true;
                foreach (string ingredient in ingredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        add = false;
                    }
                }
                if (add)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}
