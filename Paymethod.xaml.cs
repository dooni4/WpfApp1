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
    /// Interaction logic for Paymethod.xaml
    /// </summary>
    public partial class Paymethod : Page
    {
        public Paymethod()
        {
            InitializeComponent();
        }

        private void codbtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Cod.xaml", UriKind.Relative));
        }

        private void onlinebtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("onlinepayform.xaml", UriKind.Relative));
        }
    }
}
