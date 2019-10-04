﻿/**
 * SteakosaurusBurger.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class SteakosaurusBurger represents the menu item a SteakosaurusBurger. 
    /// Per request by the customer, the bun, pickles, kethcup and mustard may be removed.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        private bool bun = true; // Whether the bun is included
        private bool pickle = true; // Whether pickles are included
        private bool ketchup = true; // Whether ketchup is included
        private bool mustard = true; // Whether mustard is included

        /// <summary>
        /// A list containing all the ingredients in the Steakosaurus Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor which initializes price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// Remove the bun from the burger
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }

        /// <summary>
        /// Remove pickles from the burger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// Remove ketchup from the burger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// Remove mustard from the burger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        /// <summary>
        /// Return what the entree is
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    } // end class SteakosaurusBurger
}
