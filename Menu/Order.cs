/** Order.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Order represents an order for a customer
    /// </summary>
    public class Order
    {
        /// <summary>
        /// A list of the order items
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// The subtotal of all the items in the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0.0;
                foreach(IOrderItem item in Items)
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
        }
    }
}
