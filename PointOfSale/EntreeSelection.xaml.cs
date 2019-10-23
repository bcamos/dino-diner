/** EntreeSelection.xaml.cs
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
    /// The entrees order page
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;

        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Items.Add(entree);
            }
        }

        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Items.Add(entree);
            }
        }

        private void SelectPterodacytlWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Items.Add(entree);
            }
        }
    }
}
