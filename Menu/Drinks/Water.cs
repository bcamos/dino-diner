/* Water.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class water represents the menu item water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Whether a lemon is included on the glass of water
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// A list containing the ingredients of the water
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// An array containing all the special accomodations to this order of water
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (Lemon) specials.Add("Add Lemon");
                if (!Ice) specials.Add("Hold Ice");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// returns the type of drink
        /// </summary>
        public override string Type
        {
            get
            {
                return "Jurrasic Java";
            }
        }

        /// <summary>
        /// Default constructor sets price, calories, and size to small
        /// </summary>
        public Water()
        {
            Calories = 0;
            Price = 0.10;
            Size = Size.Small;
            ImagePath = "Images/DinoDiner-15.png";
        }

        /// <summary>
        /// Add a lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Lemon");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns what the drink is
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
