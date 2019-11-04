/** OrderList.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Order control for the list of order items
    /// </summary>
    public partial class OrderList : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderList()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// Remove the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Open the appropriate menu item window when an order item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if(OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if(OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new CustomizeEntree(entree, (Page)NavigationService.Content));
            }
        }
    }
}
