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
        /// Default constructor which initializes the price and calories
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Remove the dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }

        /// <summary>
        /// Remove the lettuce from the wrap
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Remove the cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
    } // end class VelociWrap
}
