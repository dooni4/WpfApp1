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



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {



        public Personal() => InitializeComponent();
        

            private void submit_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("onlinepayform.xaml", UriKind.Relative));

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[custinfo1]
             ([NAME]
             ,[AGE]
             ,[PHONE NUMBER]
             ,[MAIL]
             ,[ADDRESS]
             )
               VALUES
                ('" + name.Text + "', '" + age.Text + "',  '" + pn.Text + "',  '" + mail.Text + "',  '" +adrs.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void update_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  custinfo1 set AGE='"+age.Text+"' where NAME= '" + name.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("customer information deleted updated");


        }
        private void delete_Click(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from custinfo1 where NAME= '" + name.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("customer information deleted");

            


        }
        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50UQ5B5;Initial Catalog=ECOMp;Integrated Security=True;");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from custinfo1 where NAME = @Name";
            cmd.Parameters.AddWithValue("@Name", name.Text); // Use parameterized query to prevent SQL injection

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            datagrid.ItemsSource = dt.DefaultView; // Set DataTable's DefaultView as ItemsSource

            con.Close();
        }



    }
}
