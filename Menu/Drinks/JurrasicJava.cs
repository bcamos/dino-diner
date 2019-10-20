/* JurassicJava.cs
 * Author: Ben Amos
 */
/* JurassicJava.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class JurassicJava represents the menu item JurassicJava which is coffee
    /// </summary>
    public class JurassicJava : Drink
    {
        private Size size;
        private bool decaf = false;

        /// <summary>
        /// Whether to leave room for cream or not
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether coffee is decaf or not
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The size of the coffee; adjusts price and calories as needed when changed.
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
                        Calories = 2;
                        Price = .59;
                        break;
                    case Size.Medium:
                        size = Size.Medium;
                        Calories = 4;
                        Price = .99;
                        break;
                    case Size.Large:
                        size = Size.Large;
                        Calories = 8;
                        Price = 1.49;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// The ingredients of the coffee
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }                
        }

        /// <summary>
        /// An array of the special accomodations to the jurrasic java order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (RoomForCream) specials.Add("Leave Room For Cream");
                if (Ice) specials.Add("Add Ice");
                return specials.ToArray();
            }
        }
        

        /// <summary>
        /// Default constructor sets coffee to small
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            HoldIce();
        }

        /// <summary>
        /// Leave room for cream in coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Add ice to coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns what the drink is
        /// </summary>
        /// <returns>What the drink is</returns>
        public override string ToString()
        {
            string name = Size.ToString();
            if (Decaf) name += " Decaf";
            name += " Jurassic Java";
            return name;
        }
    }
}
