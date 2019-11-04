/**
 * VelociWrap.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class VelociWrap represent the menu item Veloci Wrap.
    /// Per request by the customer, the dressing, lettuce, and cheese can be removed
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool dressing = true; // Whether the dressing is included
        private bool lettuce = true; // Whether the lettuce is included
        private bool cheese = true; // Whether cheese is included

        /// <summary>
        /// A list containing all the ingredients for the Veloci Wrap.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// A list containing all the special accomodations to the veloci wrap order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!dressing) specials.Add("Hold Dressing");
                if (!lettuce) specials.Add("Hold Lettuce");
                if (!cheese) specials.Add("Hold Cheese");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Default constructor which initializes the price and calories
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ImagePath = "Images/DinoDiner-07.png";
        }

        /// <summary>
        /// Remove the dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the lettuce from the wrap
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Remove the cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns what the entree is
        /// </summary>
        /// <returns>What the entree is</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    } // end class VelociWrap
}
