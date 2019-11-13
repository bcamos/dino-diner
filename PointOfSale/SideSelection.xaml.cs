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
        private DDSize size;

        /// <summary>
        /// Initializes size to small and checks the correct button
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            size = DDSize.Small;
            InitializeSizeCheckButton();
        }       

        /// <summary>
        /// Constructor which initializes the side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            size = side.Size;
            InitializeSizeCheckButton();
        }

        /// <summary>
        /// Constructor which initializes the combo and the side
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
            combo.Side = side;
            size = side.Size;
            InitializeSizeCheckButton();
        }

        /// <summary>
        /// Checks the appropriate size button for initialization
        /// </summary>
        private void InitializeSizeCheckButton()
        {
            switch (size)
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
        /// Returns to the appropriate page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Done_Click(object sender, RoutedEventArgs args)
        {
            if(combo == null)
            {
                NavigationService.GoBack();                
            }
            else
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
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
                side = new Triceritots();
                side.Size = size;
                if (combo == null)
                {                    
                    order.Add(side);
                }                
                else
                {
                    combo.Side = side;                    
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
                side = new MeteorMacAndCheese();
                side.Size = size;
                if (combo == null)
                {                    
                    order.Add(side);
                }
                else
                {
                    combo.Side = side;                    
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
                side = new MezzorellaSticks();
                side.Size = size;
                if (combo == null)
                {                    
                    order.Add(side);
                }
                else
                {
                    combo.Side = side;                    
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
                side = new Fryceritops();
                side.Size = size;
                if (combo == null)
                {                    
                    order.Add(side);
                }
                else
                {
                    combo.Side = side;                    
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
                size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                if (side != null)
                {
                    side.Size = size;                    
                }                           
            }
        }
    }
}
