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
    public class Water : Drink, IMenuItem
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
        /// Default constructor sets price, calories, and size to small
        /// </summary>
        public Water()
        {
            Calories = 0;
            Price = 0.10;
            Size = Size.Small;
        }

        /// <summary>
        /// Add a lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
