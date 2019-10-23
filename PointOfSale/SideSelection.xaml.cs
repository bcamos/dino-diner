/** SideSelection.xaml.cs
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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// The side menu
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;

        public SideSelection()
        {
            InitializeComponent();
        }

        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Triceritots();
                order.Items.Add(side);
            }
        }

        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Items.Add(side);
            }
        }

        private void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Items.Add(side);
            }
        }

        private void SelectFryceritots(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                order.Items.Add(side);
            }            
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize) Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
