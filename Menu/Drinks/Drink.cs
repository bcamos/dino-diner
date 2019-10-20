/* Drink.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Anstract class Drink represents the menu item a drink
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size;

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
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// A description of what the drink is
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// An array of all the special accomodations to the drink
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Whether the drink has ice in it or not
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// An event handler for when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Add the property event args for the given property
        /// </summary>
        /// <param name="propertyName">The property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Remove Ice from drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
    }
}
