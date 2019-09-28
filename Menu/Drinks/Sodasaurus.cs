/* Sodasaurus.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class Sodasaurus represents the menu a item a sodasaurus which is a soda
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;

        /// <summary>
        /// The flavor of the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// The size of the sodasaurus; adjusts price and calories as needed when changed.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                switch (value)
                {
                    case Size.Small:
                        size = Size.Small;
                        Calories = 112;
                        Price = 1.5;
                        break;
                    case Size.Medium:
                        size = Size.Medium;
                        Calories = 156;
                        Price = 2;
                        break;
                    case Size.Large:
                        size = Size.Large;
                        Calories = 208;
                        Price = 2.5;
                        break;
                }
            }
        }

        /// <summary>
        /// The ingredients of the sodasaurus
        /// </summary>
        public override List<string> Ingredients { get; set; } = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };

        /// <summary>
        /// Default constructor sets soda to small
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }
    }
}
