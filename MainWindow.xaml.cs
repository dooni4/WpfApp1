using MongoDB.Driver;
using System.Net.Mail;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
       


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CART_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("cartpage2.xaml",UriKind.Relative));
        }


        private void Desc_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("WpfApp2.xaml", UriKind.Relative));

        }

        private void Shopnw_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("shoppage.xaml", UriKind.Relative));
        }

       
    }
}