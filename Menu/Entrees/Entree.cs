/** Entree.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class to represent an entree
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// The ingredients of the entree
        /// </summary>
        public abstract List<string> Ingredients { get; }

    }
}
