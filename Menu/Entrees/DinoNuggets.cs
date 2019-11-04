/**
 * DinoNuggets.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class DinoNuggets represents the menu item Dino Nuggets. Per request the customer may add additional nuggets
    /// from the default of 6 for an extra 25 cents.
    /// </summary>
    public class DinoNuggets : Entree
    {
        private int nuggets = 6; // The number of nuggets

        /// <summary>
        /// The total calories of the nuggets
        /// </summary>
        public override uint Calories
        {
            get
            {
                return (uint)nuggets * 59;
            }
        }

        /// <summary>
        /// A list containing all the ingredients of Dino Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// A list containing any special accomations to the order of dino nuggets
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if(nuggets > 6)
                {
                    specials.Add((nuggets - 6) + " Extra Nuggets");
                }
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Default constructor which initializes price
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            ImagePath = "Images/DinoDiner-02.png";
        }

        /// <summary>
        /// Add a nugget to an order of Dino Nuggets
        /// </summary>
        public void AddNugget()
        {
            nuggets++;
            Price += .25;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Returns what the entree is
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    } // end class DinoNuggets

}