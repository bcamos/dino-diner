/** CustomizeEntree.xaml.cs
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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        CretaceousCombo combo;
        Entree entree;
        Page nextPage;

        /// <summary>
        /// Initializes the entree and makes the correct setup
        /// </summary>
        /// <param name="entree"></param>
        /// <param name="nextPage"></param>
        public CustomizeEntree(Entree entree, Page nextPage)
        {
            InitializeComponent();
            this.nextPage = nextPage;
            this.entree = entree;
            SetupScreen(entree);
        }

        /// <summary>
        /// Initializes the combo and entree and makes the correct setup
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="nextPage"></param>
        public CustomizeEntree(CretaceousCombo combo, Page nextPage)
        {
            InitializeComponent();
            this.nextPage = nextPage;
            this.combo = combo;
            this.entree = combo.Entree;
            SetupScreen(entree);
        }

        /// <summary>
        /// Sets the design appropriately for the entree
        /// </summary>
        /// <param name="entree"></param>
        private void SetupScreen(Entree entree)
        {
            EntreeImage.Source = new BitmapImage(new Uri(entree.ImagePath, UriKind.Relative));
            if (entree is Brontowurst b)
            {
                BrontowurstSetup();
            }
            else if (entree is DinoNuggets dn)
            {
                DinoNuggetsSetup();
            }
            else if (entree is PrehistoricPBJ pbj)
            {
                PrehistoricPBJSetup();
            }
            else if (entree is SteakosaurusBurger sb)
            {
                SteakosaurusBurgerSetup();
            }
            else if (entree is TRexKingBurger tb)
            {
                TRexKingBurgerSetup();
            }
            else if (entree is VelociWrap vw)
            {
                VelociWrapSetup();
            }
            CustomizeEntreeButtons.Children.Add(DoneButton());
        }

        /// <summary>
        /// Add buttons for the brontowurst
        /// </summary>
        private void BrontowurstSetup()
        {
            CustomizeEntreeButtons.Children.Add(HoldBunButton());
            CustomizeEntreeButtons.Children.Add(HoldOnionButton());
            CustomizeEntreeButtons.Children.Add(HoldPeppersButton());
        }

        /// <summary>
        /// Add buttons for the dino nuggets
        /// </summary>
        private void DinoNuggetsSetup()
        {
            CustomizeEntreeButtons.Children.Add(AddNuggetButton());
            CustomizeEntreeButtons.Children.Add(AddTwoNuggetsButton());
            CustomizeEntreeButtons.Children.Add(AddFourNuggetsButton());
        }

        /// <summary>
        /// Add buttons for the PB&J
        /// </summary>
        private void PrehistoricPBJSetup()
        {
            CustomizeEntreeButtons.Children.Add(HoldJellyButton());
            CustomizeEntreeButtons.Children.Add(HoldPeanutButterButton());
        }

        /// <summary>
        /// Add buttons for the steakosaurus burger
        /// </summary>
        private void SteakosaurusBurgerSetup()
        {
            CustomizeEntreeButtons.Children.Add(HoldBunButton());
            CustomizeEntreeButtons.Children.Add(HoldKetchupButton());
            CustomizeEntreeButtons.Children.Add(HoldMustardButton());
            CustomizeEntreeButtons.Children.Add(HoldPickleButton());
        }

        /// <summary>
        /// Add buttons for the T-Rex King Burger
        /// </summary>
        private void TRexKingBurgerSetup()
        {
            StackPanel sp = new StackPanel();
            sp.Width = CustomizeEntreeButtons.Width;
            sp.Orientation = Orientation.Horizontal;

            StackPanel sp1 = new StackPanel();
            sp1.Width = sp.Width / 2 - 10;
            sp1.Orientation = Orientation.Vertical;
            sp1.Children.Add(HoldBunButton());
            sp1.Children.Add(HoldKetchupButton());
            sp1.Children.Add(HoldMustardButton());
            sp1.Children.Add(HoldPickleButton());
            sp.Children.Add(sp1);

            StackPanel sp2 = new StackPanel();
            sp2.Orientation = Orientation.Vertical;
            sp2.Width = sp.Width / 2 - 10;
            sp2.Children.Add(HoldOnionButton());
            sp2.Children.Add(HoldLettuceButton());
            sp2.Children.Add(HoldMayoButton());
            sp2.Children.Add(HoldTomatoButton());
            sp.Children.Add(sp2);

            CustomizeEntreeButtons.Children.Add(sp);          
        }

        /// <summary>
        /// Add buttons for the veloci wrap
        /// </summary>
        private void VelociWrapSetup()
        {
            CustomizeEntreeButtons.Children.Add(HoldLettuceButton());
            CustomizeEntreeButtons.Children.Add(HoldCheeseButton());
            CustomizeEntreeButtons.Children.Add(HoldDressingButton());            
        }

        /// <summary>
        /// Updates the combo when changes have happened to the entree
        /// </summary>
        private void UpdateCombo()
        {
            if(combo != null)
            {
                combo.NotifyOfAllPropertyChanges();
            }
        }

        /// <summary>
        /// Make a done button
        /// </summary>
        /// <returns>A done button</returns>
        private Button DoneButton()
        {
            Button b = new Button();
            b.Content = "Done";
            b.Background = new SolidColorBrush(Colors.LightYellow);
            b.Click += new RoutedEventHandler(Done_Click);
            return b;
        }

        /// <summary>
        /// Make a hold bun button
        /// </summary>
        /// <returns>A hold bun button</returns>
        private Button HoldBunButton()
        {
            Button b = new Button();
            b.Content = "- Hold Bun";
            b.Background = new SolidColorBrush(Colors.Orange);
            b.Click += new RoutedEventHandler(HoldBun_Click);
            return b;
        }

        /// <summary>
        /// Make a hold onion button
        /// </summary>
        /// <returns>A hold onion button</returns>
        private Button HoldOnionButton()
        {
            Button b = new Button();
            b.Content = "- Hold Onion";
            b.Background = new SolidColorBrush(Colors.BlanchedAlmond);
            b.Click += new RoutedEventHandler(HoldOnion_Click);
            return b;
        }

        /// <summary>
        /// Make a hold peppers button
        /// </summary>
        /// <returns>A hold peppers button</returns>
        private Button HoldPeppersButton()
        {
            Button b = new Button();
            b.Content = "- Hold Peppers";
            b.Background = new SolidColorBrush(Colors.DimGray);
            b.Click += new RoutedEventHandler(HoldPeppers_Click);
            return b;
        }

        /// <summary>
        /// Make an add nugget button
        /// </summary>
        /// <returns>An add nugget button</returns>
        private Button AddNuggetButton()
        {
            Button b = new Button();
            b.Content = "+ Add Nugget";
            b.Tag = 1;
            b.Background = new SolidColorBrush(Colors.DarkOrange);
            b.Click += new RoutedEventHandler(AddNugget_Click);
            return b;
        }

        /// <summary>
        /// Make an add two nuggets button
        /// </summary>
        /// <returns>An add two nuggets button</returns>
        private Button AddTwoNuggetsButton()
        {
            Button b = new Button();
            b.Content = "+ Add 2 Nuggets";
            b.Tag = 2;
            b.Background = new SolidColorBrush(Colors.Orange);
            b.Click += new RoutedEventHandler(AddNugget_Click);
            return b;
        }

        /// <summary>
        /// Make an add four nuggets button
        /// </summary>
        /// <returns>An add four nuggets button</returns>
        private Button AddFourNuggetsButton()
        {
            Button b = new Button();
            b.Content = "+ Add 4 Nuggets";
            b.Tag = 4;
            b.Background = new SolidColorBrush(Colors.OrangeRed);
            b.Click += new RoutedEventHandler(AddNugget_Click);
            return b;
        }

        /// <summary>
        /// Make a hold jelly button
        /// </summary>
        /// <returns>A hold jelly button</returns>
        private Button HoldJellyButton()
        {
            Button b = new Button();
            b.Content = "- Hold Jelly";
            b.Background = new SolidColorBrush(Colors.MediumPurple);
            b.Click += new RoutedEventHandler(HoldJelly_Click);
            return b;
        }

        /// <summary>
        /// Make a hold peanut butter button
        /// </summary>
        /// <returns>A hold peanut butter button</returns>
        private Button HoldPeanutButterButton()
        {
            Button b = new Button();
            b.Content = "- Hold Peanut Butter";
            b.Background = new SolidColorBrush(Colors.PaleGoldenrod);
            b.Click += new RoutedEventHandler(HoldPeanutButter_Click);
            return b;
        }

        /// <summary>
        /// Make a hold ketchup button
        /// </summary>
        /// <returns>A hold ketchup button</returns>
        private Button HoldKetchupButton()
        {
            Button b = new Button();
            b.Content = "- Hold Ketchup";
            b.Background = new SolidColorBrush(Colors.Red);
            b.Click += new RoutedEventHandler(HoldKetchup_Click);
            return b;
        }

        /// <summary>
        /// Make a hold mustard button
        /// </summary>
        /// <returns>A hold mustard button</returns>
        private Button HoldMustardButton()
        {
            Button b = new Button();
            b.Content = "- Hold Mustard";
            b.Background = new SolidColorBrush(Colors.Yellow);
            b.Click += new RoutedEventHandler(HoldMustard_Click);
            return b;
        }

        /// <summary>
        /// Make a hold pickle button
        /// </summary>
        /// <returns>A hold pickle button</returns>
        private Button HoldPickleButton()
        {
            Button b = new Button();
            b.Content = "- Hold Pickle";
            b.Background = new SolidColorBrush(Colors.DarkOliveGreen);
            b.Click += new RoutedEventHandler(HoldPickle_Click);
            return b;
        }

        /// <summary>
        /// Make a hold lettuce button
        /// </summary>
        /// <returns>A hold lettuce button</returns>
        private Button HoldLettuceButton()
        {
            Button b = new Button();
            b.Content = "- Hold Lettuce";
            b.Background = new SolidColorBrush(Colors.LawnGreen);
            b.Click += new RoutedEventHandler(HoldLettuce_Click);
            return b;
        }

        /// <summary>
        /// Make a hold mayo button
        /// </summary>
        /// <returns>A hold mayo button</returns>
        private Button HoldMayoButton()
        {
            Button b = new Button();
            b.Content = "- Hold Mayo";
            b.Background = new SolidColorBrush(Colors.Azure);
            b.Click += new RoutedEventHandler(HoldMayo_Click);
            return b;
        }

        /// <summary>
        /// Make a hold tomato button
        /// </summary>
        /// <returns>A hold tomato button</returns>
        private Button HoldTomatoButton()
        {
            Button b = new Button();
            b.Content = "- Hold Tomato";
            b.Background = new SolidColorBrush(Colors.OrangeRed);
            b.Click += new RoutedEventHandler(HoldTomato_Click);
            return b;
        }

        /// <summary>
        /// Make a hold cheese button
        /// </summary>
        /// <returns>A hold cheese button</returns>
        private Button HoldCheeseButton()
        {
            Button b = new Button();
            b.Content = "- Hold Cheese";
            b.Background = new SolidColorBrush(Colors.Yellow);
            b.Click += new RoutedEventHandler(HoldCheese_Click);
            return b;
        }

        /// <summary>
        /// Make a hold dressing button
        /// </summary>
        /// <returns>A hold dressing button</returns>
        private Button HoldDressingButton()
        {
            Button b = new Button();
            b.Content = "- Hold Dressing";
            b.Background = new SolidColorBrush(Colors.White);
            b.Click += new RoutedEventHandler(HoldDressing_Click);
            return b;
        }

        /// <summary>
        /// Navigate to the next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(nextPage);
        }

        /// <summary>
        /// Hold bun on the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs args)
        {
            if(entree is Brontowurst b)
            {
                b.HoldBun();
            }

            else if(entree is SteakosaurusBurger sb)
            {
                sb.HoldBun();
            }
            else if(entree is TRexKingBurger tb)
            {
                tb.HoldBun();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold onion for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldOnion_Click(object sender, RoutedEventArgs args)
        {
            if(entree is Brontowurst b)
            {
                b.HoldOnion();
            }
            else if(entree is TRexKingBurger tb)
            {
                tb.HoldOnion();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold peppers for the brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldPeppers_Click(object sender, RoutedEventArgs args)
        {
            if(entree is Brontowurst b)
            {
                b.HoldPeppers();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Add a nugget to the dino nuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddNugget_Click(object sender, RoutedEventArgs args)
        {
            if(entree is DinoNuggets dn)
            {
                if(sender is Button b)
                {
                    for(int i = 0; i < (int)b.Tag; i++)
                    {
                        dn.AddNugget();
                    }
                }
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold jelly for the PBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldJelly_Click(object sender, RoutedEventArgs args)
        {
            if(entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold peanut butter for the PBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldPeanutButter_Click(object sender, RoutedEventArgs args)
        {
            if(entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold ketchup for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldKetchup_Click(object sender, RoutedEventArgs args)
        {
            if(entree is SteakosaurusBurger sb)
            {
                sb.HoldKetchup();
            }
            else if(entree is TRexKingBurger tb)
            {
                tb.HoldKetchup();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold mustard for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldMustard_Click(object sender, RoutedEventArgs args)
        {
            if(entree is SteakosaurusBurger sb)
            {
                sb.HoldMustard();
            }
            else if(entree is TRexKingBurger tb)
            {
                tb.HoldMustard();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold pickle for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldPickle_Click(object sender, RoutedEventArgs args)
        {
            if(entree is SteakosaurusBurger sb)
            {
                sb.HoldPickle();
            }
            else if(entree is TRexKingBurger tb)
            {
                tb.HoldPickle();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold lettuce for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldLettuce_Click(object sender, RoutedEventArgs args)
        {
            if(entree is TRexKingBurger tb)
            {
                tb.HoldLettuce();
            }
            else if(entree is VelociWrap vw)
            {
                vw.HoldLettuce();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold mayo for the T-Rex King Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldMayo_Click(object sender, RoutedEventArgs args)
        {
            if(entree is TRexKingBurger tb)
            {
                tb.HoldMayo();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold tomato for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldTomato_Click(object sender, RoutedEventArgs args)
        {
            if(entree is TRexKingBurger tb)
            {
                tb.HoldTomato();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold cheese for the veloci wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldCheese_Click(object sender, RoutedEventArgs args)
        {
            if(entree is VelociWrap vw)
            {
                vw.HoldCheese();
            }
            UpdateCombo();
        }

        /// <summary>
        /// Hold dressing for the veloci wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void HoldDressing_Click(object sender, RoutedEventArgs args)
        {
            if(entree is VelociWrap vw)
            {
                vw.HoldDressing();
            }
            UpdateCombo();
        }
    }
}
