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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for shoppage.xaml
    /// </summary>
    public partial class shoppage : Page
    {
       

        public shoppage()
        {
            InitializeComponent();
           
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("spdm.xaml", UriKind.Relative));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("digsm.xaml", UriKind.Relative));
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("led.xaml", UriKind.Relative));
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("dashcam.xaml", UriKind.Relative));
        }
        private void atc1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("cartpage2.xaml", UriKind.Relative));
        }

        private void atc2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("cartpage2.xaml", UriKind.Relative));
        }

        private void atc3_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("cartpage2.xaml", UriKind.Relative));
        }
        private void atc4_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("cartpage2.xaml", UriKind.Relative));
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(null);
        }
    }
}
