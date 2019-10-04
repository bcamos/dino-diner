/* JurassicJava.cs
 * Author: Ben Amos
 */
/* JurrasicJava.cs
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
    public class JurrasicJava : Drink
    {
        private Size size;

        /// <summary>
        /// Whether to leave room for cream or not
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Whether coffee is decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

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
            }
        }

        /// <summary>
        /// The ingredients of the coffee
        /// </summary>
        public override List<string> Ingredients { get; set; } = new List<string>() { "Water", "Coffee" };
        

        /// <summary>
        /// Default constructor sets coffee to small
        /// </summary>
        public JurrasicJava()
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
        }

        /// <summary>
        /// Add ice to coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
