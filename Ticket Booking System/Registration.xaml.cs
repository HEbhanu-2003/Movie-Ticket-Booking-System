using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Ticket_Booking_System
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True");
                con.Open();

                if (txt_ID.Text != string.Empty && txt_Username.Text != string.Empty && txt_Password.Password != string.Empty)

                {

                    String Querry = "Select * from Registration_Details WHERE RegisterId = '" + txt_ID.Text + "'";
                    SqlCommand cmd = new SqlCommand(Querry, con);

                    SqlDataReader Sdr = cmd.ExecuteReader();

                    if (Sdr.Read())
                    {
                        Sdr.Close();
                        MessageBox.Show("Id Already Used please try another", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Sdr.Close();
                        SqlCommand cmd1 = new SqlCommand(@"Insert Into Registration_Details Values (@RegisterId,@UserName,@Password)", con);

                        cmd1.Parameters.AddWithValue("@RegisterId", txt_ID.Text);
                        cmd1.Parameters.AddWithValue("@UserName", txt_Username.Text);
                        cmd1.Parameters.AddWithValue("@Password", txt_Password.Password);

                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Register Successfully", "Registered", MessageBoxButton.OK, MessageBoxImage.Information);

                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Please Fiil In The Blanks", "Fiil In The Blanks", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            

        }
    }
}
