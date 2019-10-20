/* Sodasaurus.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Sodasaurus represents the menu a item a sodasaurus which is a soda
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;
        private SodasaurusFlavor flavor;

        /// <summary>
        /// The flavor of the Sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
                NotifyOfPropertyChanged("Description");
            }
        }

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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// An array of all the special accomodations for the sodasaurus order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!Ice) specials.Add("Hold Ice");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// The ingredients of the sodasaurus
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }  

        /// <summary>
        /// Default constructor sets soda to small
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Returns what the drink is
        /// </summary>
        /// <returns>Returns what the drink is</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Flavor.ToString() + " Sodasaurus";
        }
    }
}
