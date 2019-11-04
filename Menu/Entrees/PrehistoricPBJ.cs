/** PrehistoricPBJ.cs
 * Author: Nathan Bean, Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class PrehistoricPBJ represents the menu item Prehistoric Peanut Butter and Jelly sandwich.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;


        

        /// <summary>
        /// A list containing all the ingredients of PBJ
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// A list containing all special accomodations to the PBJ order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Default constructor that sets price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            ImagePath = "Images/DinoDiner-03.png";
        }

        /// <summary>
        /// Remove peanut butter from sandwich
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Remove jelly from sandwich
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns what the entree is
        /// </summary>
        /// <returns>What the entree is</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
