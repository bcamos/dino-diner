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

        private void CustomizeSelectEntree(Entree entree)
        {
            NavigationService.Navigate(new CustomizeEntree(entree, new MenuCategorySelection()));
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
                Brontowurst b = new Brontowurst();
                order.Add(b);
                CustomizeSelectEntree(b);
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
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                CustomizeSelectEntree(sb);
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
                NavigationService.Navigate(new MenuCategorySelection());
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
                TRexKingBurger tb = new TRexKingBurger();
                order.Add(tb);
                CustomizeSelectEntree(tb);
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
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                CustomizeSelectEntree(dn);
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
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                CustomizeSelectEntree(pbj);                
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
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                CustomizeSelectEntree(vw);
            }
        }
    }
}
