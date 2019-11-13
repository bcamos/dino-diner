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
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// The drinks menu page
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        private CretaceousCombo combo;
        private DDSize size;

        /// <summary>
        /// Initizalizes size to small, and checks the small button
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            size = DDSize.Small;
            SmallButton.IsChecked = true;
        }

        /// <summary>
        /// Constructor which initializes drink
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            size = drink.Size;
            ButtonSetup();
        } 

        /// <summary>
        /// Construcctor which intializes combo and drink
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = combo.Drink;
            combo.Drink = drink;
            size = drink.Size;
            ButtonSetup();
        }

        /// <summary>
        /// Setup buttons for the appropriate drink and check correct size button
        /// </summary>
        private void ButtonSetup()
        {
            if (drink is Sodasaurus s)
            {
                SodasaurusSetup();
            }
            else if (drink is Tyrannotea t)
            {
                TyrannoteaSetup();
            }
            else if (drink is JurassicJava j)
            {
                JurrasicJavaSetup();
            }
            else if (drink is Water w)
            {
                WaterSetup();
            }

            switch (drink.Size)
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
        /// Setup buttons for sodasaurus
        /// </summary>
        private void SodasaurusSetup()
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddSodaflavorButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());
            uxDynamicButtonPanel.Children.Add(AddDoneButton());
            ResetLabels();
            uxSodasaurusLabel.Content = "* Sodasaurus";
        }

        /// <summary>
        /// Setup buttons for tyrannotea
        /// </summary>
        private void TyrannoteaSetup()
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddSweetButton());
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());
            uxDynamicButtonPanel.Children.Add(AddDoneButton());
            ResetLabels();
            uxTyrannoteaLabel.Content = "* Tyrannotea";
        }

        /// <summary>
        /// Setup buttons for jurrasic java
        /// </summary>
        private void JurrasicJavaSetup()
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddDecafButton());
            uxDynamicButtonPanel.Children.Add(AddAddIceButton());
            uxDynamicButtonPanel.Children.Add(AddDoneButton());
            ResetLabels();
            uxJurrasicJavaLabel.Content = "* Jurrasic Java";
        }

        /// <summary>
        /// Setup buttons for water
        /// </summary>
        private void WaterSetup()
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());
            uxDynamicButtonPanel.Children.Add(AddDoneButton());
            ResetLabels();
            uxWaterLabel.Content = "* Water";
        }

        /// <summary>
        /// Updates the combo of changes to the drink: notifying of changes
        /// </summary>
        private void UpdateCombo()
        {
            if(combo != null)
            {
                combo.NotifyOfAllPropertyChanges();
            }            
        }

        /// <summary>
        /// When the Sodasaurus is clicked, it adds a button for the flavor and whether to hold ice
        /// </summary>
        /// <param name="sender">The Sodasaurus button</param>
        /// <param name="args"></param>
        public void SelectSodasaurus_Click(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {                
                drink = new Sodasaurus();
                drink.Size = size;
                if (combo == null)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }                
                SodasaurusSetup();
            }            
        }

        /// <summary>
        /// When the Tyrannotea is clicked, it adds a button for sweet, lemon, and ice.
        /// </summary>
        /// <param name="sender">The Tyrannotea button</param>
        /// <param name="args"></param>
        public void SelectTyrannotea_Click(object sender, RoutedEventArgs args)
        {            
            if(DataContext is Order order)
            {
                drink = new Tyrannotea();
                drink.Size = size;
                if(combo == null)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }
                TyrannoteaSetup();
            }
        }

        /// <summary>
        /// When the JurrasicJava is clicked, it adds a button for decaf and ice.
        /// </summary>
        /// <param name="sender">The JurrasicJava button</param>
        /// <param name="args"></param>
        public void SelectJurrasicJava_Click(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                drink = new JurassicJava();
                drink.Size = size;
                if (combo == null)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }                
                JurrasicJavaSetup();
            }            
        }

        /// <summary>
        /// When Water is clicked, it adds a button for lemon and ice.
        /// </summary>
        /// <param name="sender">The Water button</param>
        /// <param name="args"></param>
        public void SelectWater_Click(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                drink = new Water();
                drink.Size = size;
                if(combo == null)
                {
                    order.Add(drink);
                }
                else
                {
                    combo.Drink = drink;
                }                
                WaterSetup();
            }            
        }

        /// <summary>
        /// Open flavor window when the flavor button is clicked
        /// </summary>
        /// <param name="sender">The flavor button</param>
        /// <param name="args"></param>
        public void SelectFlavor_Click(object sender, RoutedEventArgs args)
        {
            if(combo == null)
            {
                NavigationService.Navigate(new FlavorSelection(drink));
            }
            else
            {
                NavigationService.Navigate(new FlavorSelection(combo));
            }
        }

        /// <summary>
        /// Return to the menu category selection screen
        /// </summary>
        /// <param name="sender">The done button</param>
        /// <param name="args"></param>
        public void SelectDone_Click(object sender, RoutedEventArgs args)
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
        /// Hold ice for the drink
        /// </summary>
        /// <param name="sender">The hold ice button</param>
        /// <param name="args"></param>
        public void SelectHoldIce_Click(object sender, RoutedEventArgs args)
        {
            drink.HoldIce();            
        }

        /// <summary>
        /// Add ice for a jurrasic java
        /// </summary>
        /// <param name="sender">Add ice button</param>
        /// <param name="args"></param>
        public void SelectAddIce_Click(object sender, RoutedEventArgs args)
        {
            if(drink is JurassicJava j)
            {
                j.AddIce();                
            }            
        }

        /// <summary>
        /// Set the jurrasic java to decaf
        /// </summary>
        /// <param name="sender">The decaf button</param>
        /// <param name="args"></param>
        public void SelectDecaf_Click(object sender, RoutedEventArgs args)
        {
            if(drink is JurassicJava j)
            {
                j.Decaf = true;                
            }            
        }

        /// <summary>
        /// Set the tyrannotea to sweet
        /// </summary>
        /// <param name="sender">The sweet button</param>
        /// <param name="args"></param>
        public void SelectSweet_Click(object sender, RoutedEventArgs args)
        {
            if(drink is Tyrannotea t)
            {
                t.Sweet = true;                
            }            
        }

        /// <summary>
        /// Add a lemon to either the water or the tyrannotea
        /// </summary>
        /// <param name="sender">Add lemon button</param>
        /// <param name="args"></param>
        public void SelectAddLemon_Click(object sender, RoutedEventArgs args)
        {
            if(drink is Water w)
            {
                w.AddLemon();
            }
            else if(drink is Tyrannotea t)
            {
                t.AddLemon();
            }            
        }

        /// <summary>
        /// Change the size of the drink
        /// </summary>
        /// <param name="sender">A size button</param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                if(drink != null)
                {
                    drink.Size = size;
                }                
            }            
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
            b.Click += new RoutedEventHandler(SelectHoldIce_Click);
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
            b.Click += new RoutedEventHandler(SelectAddIce_Click);
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
            b.Click += new RoutedEventHandler(SelectDecaf_Click);
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
            b.Click += new RoutedEventHandler(SelectSweet_Click);
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
            b.Click += new RoutedEventHandler(SelectAddLemon_Click);
            b.Background = new SolidColorBrush(Colors.Yellow);
            return b;
        }

        /// <summary>
        /// Add a done button
        /// </summary>
        /// <returns>Done button</returns>
        private Button AddDoneButton()
        {
            Button b = new Button();
            b.Content = "Done";
            b.Click += new RoutedEventHandler(SelectDone_Click);
            b.Background = new SolidColorBrush(Colors.LightYellow);
            return b;
        }
    }
}
