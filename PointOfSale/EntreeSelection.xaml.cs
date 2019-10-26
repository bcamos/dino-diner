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

        public EntreeSelection()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Add a brontowurst to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Brontowurst());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a steakosaurus burger to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new SteakosaurusBurger());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a pterodactyl wings to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPterodacytlWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new PterodactylWings());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a T-Rex King burger to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new TRexKingBurger());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a dino nuggets to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new DinoNuggets());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a pbj to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new PrehistoricPBJ());
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Add a veloci wrap to the order and return to menu category selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new VelociWrap());
                NavigationService.GoBack();
            }
        }
    }
}
