/** Triceritots.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class triceritots represents the side and menu item triceritots
    /// </summary>
    public class Triceritots : Side
    {
        private Size size;

        /// <summary>
        /// The size ordered
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Default constructor sets price, calories, and ingredients
        /// </summary>
        /// <param name="size"></param>
        public Triceritots()
        {
            Price = .99;
            Calories = 352;
            Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
