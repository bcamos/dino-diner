/* Drink.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Anstract class Drink represents the menu item a drink
    /// </summary>
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// A list containing the ingredients in the drink
        /// </summary>
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// The size of the drink that was ordered
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Whether the drink has ice in it or not
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Remove Ice from drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
