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
        private CretaceousCombo combo;

        public SideSelection()
        {
            InitializeComponent();            
        }       

        /// <summary>
        /// Constructor which initializes the side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;            
            switch(side.Size)
            {
                case DDSize.Small:
                    SmallButton.IsChecked = true;
                    break;
                case DDSize.Medium:
                    MediumButton.IsChecked = true;
                    break;
                case DDSize.Large:
                    LargeButton.IsChecked = true;
                    break;
            }
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;            
            this.side = combo.Side;
            switch (side.Size)
            {
                case DDSize.Small:
                    SmallButton.IsChecked = true;
                    break;
                case DDSize.Medium:
                    MediumButton.IsChecked = true;
                    break;
                case DDSize.Large:
                    LargeButton.IsChecked = true;
                    break;
            }
        }

        /// <summary>
        /// Add a triceritots to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    side = new Triceritots();
                    order.Add(side);
                }                
                else
                {
                    combo.Side = new Triceritots();
                }
            }
        }

        /// <summary>
        /// Add a meteor mac and cheese to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if(combo == null)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new MeteorMacAndCheese();
                }
            }
        }

        /// <summary>
        /// Add a mezzorella sticks to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if(combo == null)
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new MezzorellaSticks();
                }                
            }
        }

        /// <summary>
        /// Add a fryceritots to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFryceritots(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(combo == null)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
                else
                {
                    combo.Side = new Fryceritops();
                }
            }            
        }

        /// <summary>
        /// Change the size of the side
        /// </summary>
        /// <param name="sender">A size button</param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize) Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.GoBack();
            }
        }
    }
}
