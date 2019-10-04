/** MezzorellaSticks.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class MezzorellaSticks represents the side and menu item Mezzorella Sticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        private Size size;

        /// <summary>
        /// The size that was ordered
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Default constructor sets price, calories and ingredients
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
        }
    }
}
