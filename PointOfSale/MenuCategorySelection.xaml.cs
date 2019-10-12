/** MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// The Home Menu Screen
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open combo menu when the combo button is clicked
        /// </summary>
        /// <param name="sender">The combo button</param>
        /// <param name="args"></param>
        public void SelectCombo_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Open drink menu when the drink button is clicked
        /// </summary>
        /// <param name="sender">The drinkgs button</param>
        /// <param name="args"></param>
        public void SelectDrink_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Open entree menu when the entree button is clicked
        /// </summary>
        /// <param name="sender">The entree button</param>
        /// <param name="args"></param>
        public void SelectEntree_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Open side menu when the side button is clicked
        /// </summary>
        /// <param name="sender">The side button</param>
        /// <param name="args"></param>
        public void SelectSide_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
