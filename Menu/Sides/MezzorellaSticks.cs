/** MezzorellaSticks.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;
using System.ComponentModel;

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
        /// Return a list of all the ingredients in the MezzorellaSticks
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Default constructor sets price, calories and ingredients
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ImagePath = "Images/DinoDiner-10.png";            
        }

        /// <summary>
        /// Default constructor sets price, calories and ingredients
        /// </summary>
        public MezzorellaSticks(IOrderItem item, PropertyChangedEventHandler h)
        {
            Price = 0.99;
            Calories = 540;
            ImagePath = "Images/DinoDiner-10.png";
            InitializeParent(item, h);
        }       

        /// <summary>
        /// returns the type of side
        /// </summary>
        public override string Type
        {
            get
            {
                return "Mezzorella Sticks";
            }
        }

        /// <summary>
        /// Returns what the side is
        /// </summary>
        /// <returns>Returns what the side is</returns>
        public override string ToString()
        {
            return Size.ToString() + " Mezzorella Sticks";
        }
    }
}
