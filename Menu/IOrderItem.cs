/** IOrderItem.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// IOrderItem represents the common characteristics of an ordered item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The description of the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// A description of any special changes made to the item
        /// </summary>
        string[] Special { get; }
    }
}
