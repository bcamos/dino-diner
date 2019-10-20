/**
 * Brontowurst.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Brontowurst represents the brontowurst menu item. 
    /// Per request if the customer chooses, the bun, peppers, and onion can be removed.
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool bun = true; // Whether the bun is included
        private bool peppers = true; // Whether peppers are included
        private bool onions = true; // Whether onions are included

        /// <summary>
        /// A list of all ingredients in the brontowurst
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// An array of all special mods to this order of a bronotowurst
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!bun) specials.Add("Hold Bun");
                if (!peppers) specials.Add("Hold Peppers");
                if (!onions) specials.Add("Hold Onion");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Constructor for the brontowurst class, initializing price and calories
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }

        /// <summary>
        /// Remove the bun from the brontowurst
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Remove peppers from the brontowurst
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Remove onions from the brontowurst
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns what the entree is
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    } // end class Brontowurst
}