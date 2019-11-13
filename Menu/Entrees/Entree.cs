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
        /// Path to image of the entree
        /// </summary>
        public string ImagePath { get; protected set; }

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
        /// The parent object: this by default
        /// </summary>
        protected IOrderItem parent;

        /// <summary>
        /// Initialize the parent object of what the notifications will point to
        /// </summary>
        /// <param name="parentRef">The object</param>
        /// <param name="han">The object's handler</param>
        public void InitializeParent(IOrderItem parentRef, PropertyChangedEventHandler handler)
        {
            parent = parentRef;
            PropertyChanged = handler;
        }

        /// <summary>
        /// Add the property event args for the given property
        /// </summary>
        /// <param name="propertyName">The property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            if(parent == null)
            {
                parent = this;
            }
            PropertyChanged?.Invoke(parent, new PropertyChangedEventArgs(propertyName));
        }
    }
}
