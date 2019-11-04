/** ComboSelection.xaml.cs
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
    /// The combo menu
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open customize combo screen when a combo is clicked
        /// </summary>
        /// <param name="sender">A combo button</param>
        /// <param name="args"></param>
        public void SelectCombo_Click(object sender, RoutedEventArgs args)
        {
            if(sender is Button b)
            {
                Entree entree = new Brontowurst();
                switch(b.Tag)
                {
                    case "Brontowurst":
                        entree = new Brontowurst();
                        break;
                    case "DinoNuggets":
                        entree = new DinoNuggets();
                        break;
                    case "PrehistoricPBJ":
                        entree = new PrehistoricPBJ();
                        break;
                    case "PterodactylWings":
                        entree = new PterodactylWings();
                        break;
                    case "SteakosaurusBurger":
                        entree = new SteakosaurusBurger();
                        break;
                    case "TRexKingBurger":
                        entree = new TRexKingBurger();
                        break;
                    case "VelociWrap":
                        entree = new VelociWrap();
                        break;
                }
                CretaceousCombo combo = new CretaceousCombo(entree);
                if(DataContext is Order order)
                {
                    order.Add(combo);
                }
                NavigationService.Navigate(new CustomizeCombo(combo));
            }            
        }
        
    }
}
