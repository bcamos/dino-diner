/** Order.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Order represents an order for a customer
    /// </summary>
    public class Order : INotifyPropertyChanged
    {        
        private List<IOrderItem> items;

        /// <summary>
        /// An array of the order items
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The subtotal of all the items in the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0.0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                if (subtotal < 0) subtotal = 0.0;
                return subtotal;
            }
        }

        /// <summary>
        /// The sales tax rate for the items as a decimal
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// The total sales tax for the items
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;                
            }
        }

        /// <summary>
        /// The total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }

        /// <summary>
        /// Constructor which initializes the Sales Tax Rate
        /// </summary>
        /// <param name="salesTaxRate">The sales tax rate of the order as a decimal</param>
        public Order(double salesTaxRate)
        {
            if(salesTaxRate > 0 && salesTaxRate < 1)
            {
                SalesTaxRate = salesTaxRate;
            }
            items = new List<IOrderItem>();            
        }

        /// <summary>
        /// Notify of property changes when collection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Add the order item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Remove the order item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
    }
}
