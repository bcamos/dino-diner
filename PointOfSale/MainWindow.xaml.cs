/** MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order(.24);
            
            DataContext = order;
            OrderList.NavigationService = OrderUI.NavigationService;
        }

        /// <summary>
        /// Keep track of the order in data in each page
        /// </summary>
        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// Pass data to page when the page is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Pass data to page when the data context is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Go back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
