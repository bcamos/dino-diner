/** FlavorSelection.xaml.cs
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
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// The soda flavor menu
    /// </summary>
    public partial class FlavorSelection : Page
    {
        CretaceousCombo combo;
        Drink drink;

        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor which initializes drink
        /// </summary>
        /// <param name="drink">The drink</param>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        /// <summary>
        /// Constructor which initializes combo and drink
        /// </summary>
        /// <param name="combo"></param>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = combo.Drink;
        }

        /// <summary>
        /// Sets the flavor of the soda to the flavor
        /// </summary>
        /// <param name="sender">The flavor button</param>
        /// <param name="args"></param>
        public void FlavorClicked(object sender, RoutedEventArgs args)
        {
            if(drink is Sodasaurus soda)
            {
                if(sender is FrameworkElement element)
                {
                    soda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                    if(combo != null)
                    {
                        combo.NotifyOfAllPropertyChanges();
                    }
                }                
            }
            NavigationService.GoBack();
        }
    }
}
