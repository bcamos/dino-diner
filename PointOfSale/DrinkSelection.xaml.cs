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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();            
            uxDynamicButtonPanel.Children.Add(AddSodaflavorButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxSodasaurusLabel.Content = "* Sodasaurus";
        }

        public void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxTyrannoteaLabel.Content = "* Tyrannotea";
        }

        public void SelectJurrasicJava(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddDecafButton());
            uxDynamicButtonPanel.Children.Add(AddAddIceButton());

            ResetLabels();
            uxJurrasicJavaLabel.Content = "* Jurrasic Java";
        }

        public void SelectWater(object sender, RoutedEventArgs args)
        {
            uxDynamicButtonPanel.Children.Clear();
            uxDynamicButtonPanel.Children.Add(AddAddLemonButton());
            uxDynamicButtonPanel.Children.Add(AddHoldIceButton());

            ResetLabels();
            uxWaterLabel.Content = "* Water";
        }

        public void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void ResetLabels()
        {
            uxSodasaurusLabel.Content = "+ Sodasaurus";
            uxTyrannoteaLabel.Content = "+ Tyrannotea";
            uxJurrasicJavaLabel.Content = "+ Jurrasic Java";
            uxWaterLabel.Content = "+ Water";
        }

        private Button AddSodaflavorButton()
        {
            Button b = new Button();
            b.Content = "+ Flavor";
            b.Click += new RoutedEventHandler(SelectFlavor);
            b.Background = new SolidColorBrush(Colors.Orange);            
            return b;
        }
        
        private Button AddHoldIceButton()
        {
            Button b = new Button();
            b.Content = "- Hold Ice";
            b.Background = new SolidColorBrush(Colors.White);
            return b;
        }

        private Button AddAddIceButton()
        {
            Button b = new Button();
            b.Content = "+ Add Ice";
            b.Background = new SolidColorBrush(Colors.White);
            return b;
        }

        private Button AddDecafButton()
        {
            Button b = new Button();
            b.Content = "+ Decaf";
            b.Background = new SolidColorBrush(Colors.SaddleBrown);
            return b;
        }

        private Button AddAddLemonButton()
        {
            Button b = new Button();
            b.Content = "+ Add Lemon";
            b.Background = new SolidColorBrush(Colors.Yellow);
            return b;
        }
        

    }
}
