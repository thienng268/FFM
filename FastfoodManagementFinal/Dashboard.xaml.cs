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
using System.Windows.Shapes;

namespace FastfoodManagementFinal
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            PagesNavigation.Navigate(new System.Uri("HomeForm.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("ProductForm.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("HomeForm.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("CartForm.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
