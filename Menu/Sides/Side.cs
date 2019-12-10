/** Side.cs
 * Author: Nathan Bean, Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{   
    /// <summary>
    /// Abstract class that represents a menu item that is a side
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// A string path to the image of the side
        /// </summary>
        public string ImagePath { get; protected set; }

        /// <summary>
        /// A description of what the side is
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// An array of all the special accomodations to the side
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        /// <summary>
        /// The type of side
        /// </summary>
        public abstract string Type { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

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
