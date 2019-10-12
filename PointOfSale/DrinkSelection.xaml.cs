/** DrinkSelection.xaml.cs
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
    /// The drinks menu page
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the Sodasaurus is clicked, it adds a button for the flavor and whether to hold ice
        /// </summary>
        /// <param name="sender">The Sodasaurus button</param>
        /// <param name="args"></param>
        public void SelectSodasaurus_Click(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();            
            uxDynamicButtonPanel.Children.Add(AddSodaflavorButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxSodasaurusLabel.Content = "* Sodasaurus";
        }

        /// <summary>
        /// When the Tyrannotea is clicked, it adds a button for sweet, lemon, and ice.
        /// </summary>
        /// <param name="sender">The Tyrannotea button</param>
        /// <param name="args"></param>
        public void SelectTyrannotea_Click(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddSweetButton());
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxTyrannoteaLabel.Content = "* Tyrannotea";
        }

        /// <summary>
        /// When the JurrasicJava is clicked, it adds a button for decaf and ice.
        /// </summary>
        /// <param name="sender">The JurrasicJava button</param>
        /// <param name="args"></param>
        public void SelectJurrasicJava_Click(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddDecafButton());
            uxDynamicButtonPanel.Children.Add(AddAddIceButton());

            ResetLabels();
            uxJurrasicJavaLabel.Content = "* Jurrasic Java";
        }

        /// <summary>
        /// When Water is clicked, it adds a button for lemon and ice.
        /// </summary>
        /// <param name="sender">The Water button</param>
        /// <param name="args"></param>
        public void SelectWater_Click(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxWaterLabel.Content = "* Water";
        }

        /// <summary>
        /// Open flavor window when the flavor button is clicked
        /// </summary>
        /// <param name="sender">The flavor button</param>
        /// <param name="args"></param>
        public void SelectFlavor_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Reset all labels back to defaults
        /// </summary>
        private void ResetLabels()
        {
            uxSodasaurusLabel.Content = "+ Sodasaurus";
            uxTyrannoteaLabel.Content = "+ Tyrannotea";
            uxJurrasicJavaLabel.Content = "+ Jurrasic Java";
            uxWaterLabel.Content = "+ Water";
        }

        /// <summary>
        /// Add a flavor button
        /// </summary>
        /// <returns>Flavor button</returns>
        private Button AddSodaflavorButton()
        {
            Button b = new Button();
            b.Content = "+ Flavor";
            b.Click += new RoutedEventHandler(SelectFlavor_Click);
            b.Background = new SolidColorBrush(Colors.Orange);            
            return b;
        }
        
        /// <summary>
        /// Add a hold ice button
        /// </summary>
        /// <returns>Hold ice button</returns>
        private Button AddHoldIceButton()
        {
            Button b = new Button();
            b.Content = "- Hold Ice";
            b.Background = new SolidColorBrush(Colors.White);
            return b;
        }

        /// <summary>
        /// Add an add ice button
        /// </summary>
        /// <returns>Add ice button</returns>
        private Button AddAddIceButton()
        {
            Button b = new Button();
            b.Content = "+ Add Ice";
            b.Background = new SolidColorBrush(Colors.White);
            return b;
        }

        /// <summary>
        /// Add a decaf button
        /// </summary>
        /// <returns>Decaf button</returns>
        private Button AddDecafButton()
        {
            Button b = new Button();
            b.Content = "+ Decaf";
            b.Background = new SolidColorBrush(Colors.SaddleBrown);
            return b;
        }

        /// <summary>
        /// Add a sweet button
        /// </summary>
        /// <returns>Sweet button</returns>
        private Button AddSweetButton()
        {
            Button b = new Button();
            b.Content = "+ Sweet";
            b.Background = new SolidColorBrush(Colors.LightPink);
            return b;
        }

        /// <summary>
        /// Add a lemon button
        /// </summary>
        /// <returns>Lemon button</returns>
        private Button AddAddLemonButton()
        {
            Button b = new Button();
            b.Content = "+ Add Lemon";
            b.Background = new SolidColorBrush(Colors.Yellow);
            return b;
        }       
    }
}
