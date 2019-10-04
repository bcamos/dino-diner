/** Fryceritops.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Fryceritops represents the side and menu item Fryceritops
    /// </summary>
    public class Fryceritops : Side, IMenuItem
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Returns a list of all the ingredients in the Fryceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Default constructor initializes price, calories, and ingredients
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;            
        }

        /// <summary>
        /// Returns the size and what the side is
        /// </summary>
        /// <returns>The size and what the side is</returns>
        public override string ToString()
        {
            return Size.ToString() + " Friceritops";
        }
    }
}
