using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ticket_Booking_System
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
        String con = @"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void txt_UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Logi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pass, username;
                pass = txt_Password.Password;
                username = txt_UserName.Text;

                if (txt_UserName.Text == "" || txt_Password.Password == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButton.OK, MessageBoxImage.Error);
                }


                else if (username == "admin" && pass == "1234")
                {
                    MessageBox.Show("Login Successfully", "Loged", MessageBoxButton.OK, MessageBoxImage.Information);

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    using (SqlConnection conect = new SqlConnection(con))
                    {
                        String SelectData = "SELECT * FROM Registration_Details  WHERE (UserName =@UserName AND Password =@Password)";

                        using (SqlCommand cmd = new SqlCommand(SelectData, conect))
                        {
                            cmd.Parameters.AddWithValue("@UserName", txt_UserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", txt_Password.Password.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                MessageBox.Show("Login Successfully", "Loged", MessageBoxButton.OK, MessageBoxImage.Information);

                                Home home = new Home();
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButton.OK, MessageBoxImage.Error);
                                txt_UserName.Text = "";
                                txt_Password.Password = "";

                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Go_register_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
