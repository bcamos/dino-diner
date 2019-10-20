/** Entree.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class to represent an entree
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        /// <summary>
        /// The description of the entree
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The descriptions of all special accomodations for the entree
        /// </summary>
        public abstract string[] Special { get; }

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
    }
}
