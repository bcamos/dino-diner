/** MeteorMacAndCheese.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class MeteorMacAndCheese represents the side and menu item Meteor Mac And Cheese
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Returns a list of all the ingredients of the Meteor Mac and Cheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

        /// <summary>
        /// Default constructor initializes price, calories, and ingredients
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;            
        }

        /// <summary>
        /// Returns what the side is
        /// </summary>
        /// <returns>What the side is</returns>
        public override string ToString()
        {
            return Size.ToString() + " Meteor Mac and Cheese";
        }
    }
}
