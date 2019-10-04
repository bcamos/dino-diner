/** IMenuItem.cs
 * Author:Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// IMenuItem represents the common characteristics of MenuItems
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// The Price of the MenuItem
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The Calories of the MenuItem
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The Ingredients of the MenuItem
        /// </summary>
        List<string> Ingredients { get; }
    }
}
