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
        /// Returns a list ofall the ingredients in the triceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
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
            ImagePath = "Images/DinoDiner-11.png";
        }

        /// <summary>
        /// Returns a string that this is a triceritots
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Triceritots";
        }
    }
}
