/**
 * PterodactylWings.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class PterodactylWings represents the menu item Pterodactyl Wings.
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// A list containing all the ingredients of the wings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// A list containing all the specials accomodation to the pterodactyl wings order
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        /// <summary>
        /// Default constructor which initializes price and calories
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ImagePath = "Images/DinoDiner-04.png";
        }

        /// <summary>
        /// Returns what the entree is
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    } // end class PterodactylWings
}
