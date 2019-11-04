/** CustomizeCombo.xaml.cs
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
using System.Windows.Resources;

namespace PointOfSale
{
    /// <summary>
    /// The customize combo screen
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        CretaceousCombo combo;

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the combo and sets the correct images for the buttons and labels
        /// </summary>
        /// <param name="combo">The combo</param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            EntreeLabel.Content = combo.Entree.ToString();
            DrinkLabel.Content = combo.Drink.ToString();
            SideLabel.Content = combo.Side.ToString();

            SetButtonBackground(EntreeButton, combo.Entree.ImagePath);
            SetButtonBackground(SideButton, combo.Side.ImagePath);
            SetButtonBackground(DrinkButton, combo.Drink.ImagePath);
        }

        /// <summary>
        /// Sets the background of a button given a string path to an image
        /// </summary>
        /// <param name="b">The button to change the backgroun</param>
        /// <param name="ImagePath">The path to the image</param>
        private void SetButtonBackground(Button b, string ImagePath)
        {
            StreamResourceInfo stream = Application.GetResourceStream(new Uri(ImagePath, UriKind.Relative));
            b.Background = new ImageBrush(BitmapFrame.Create(stream.Stream));
        }

        /// <summary>
        /// Open the cusomize entree screen for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectCustomizeEntree_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeEntree(combo.Entree, (Page)NavigationService.Content));
        }

        /// <summary>
        /// Open side menu when side button is clicked
        /// </summary>
        /// <param name="sender">The side button</param>
        /// <param name="args"></param>
        public void SelectSide_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Open drink menu when drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectDrink_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        /// <summary>
        /// Set the size of the combo for both the drink and the side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SelectSize_Click(object sender, RoutedEventArgs args)
        {
            if(sender is RadioButton b)
            {
                combo.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), b.Tag.ToString());
            }
        }
    }
}
