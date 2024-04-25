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
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for onlinepayform.xaml
    /// </summary>
    public partial class onlinepayform : Page
    {
        public onlinepayform()
        {
            InitializeComponent();
        }

        private void submitonline_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("onlinepay.xaml", UriKind.Relative));
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[carddetials]
           ([CARD NUMBER]
           ,[EXPIRY DATE]
           ,[CVV])
     VALUES
           ('" + cn.Text + "', '" + xd.Text + "',  '" + cvv.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }




        private void cod_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("onlinepay.xaml", UriKind.Relative));

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE carddetials SET CVV = @Cvv WHERE [CARD NUMBER] = @CardNumber";
                    cmd.Parameters.AddWithValue("@Cvv", cvv.Text);
                    cmd.Parameters.AddWithValue("@CardNumber", cn.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer card information updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Please check the card number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from carddetials where CVV= '" + cvv.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("customer  card information deleted");
        }

        
    }
}
