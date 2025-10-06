using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        public Booking(String MovieName)
        {
            InitializeComponent();
            Movie_Title.Text = MovieName;

        }

        CalPrice CalPrice = new CalPrice();

        private void Booking_Load(object sender, EventArgs e)
        {
            Movie_Title.Text = Home.passingTitle;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Book(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                con.Open();

                String Querry = "Select * from MoviesTiketsBookingDetails WHERE BookingId = '" + txt_ID.Text + "'";
                SqlCommand cmd = new SqlCommand(Querry, con);

                SqlDataReader Sdr = cmd.ExecuteReader();



                if (txt_ID.Text != string.Empty && Date.Text != string.Empty && combobox1.Text != string.Empty)

                {

                    if (Sdr.Read())
                    {
                        Sdr.Close();
                        MessageBox.Show("Id Already Used please try another", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }

                    else
                    {
                        
                        Sdr.Close();
                        SqlCommand cmd1 = new SqlCommand(@"Insert Into MoviesTiketsBookingDetails Values (@BookingId, @Name,@Date,@Tickets, @Price) ", con);

                        cmd1.Parameters.AddWithValue("@BookingId", txt_ID.Text);
                        cmd1.Parameters.AddWithValue("@Name", Movie_Title.Text);
                        cmd1.Parameters.AddWithValue("@Date", Date.Text);
                        cmd1.Parameters.AddWithValue("@Tickets", combobox1.Text);
                        cmd1.Parameters.AddWithValue("@Price", txt_total.Text);

                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Your Booking Succefully", "Booked", MessageBoxButton.OK, MessageBoxImage.Information);

                        BookSeates bookSeates = new BookSeates(Movie_Title.Text, Convert.ToInt32(combobox1.Text), Convert.ToInt32(txt_total.Text), Convert.ToInt32(txt_ID.Text));
                        bookSeates.Show();
                        this.Hide();

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
                MessageBox.Show(ex.Message);
            }


        }

        private void Edite(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_ID.Text == "" || Date.Text == "" || combobox1.Text == "")
                {
                    MessageBox.Show("Please Fiil In The Blanks", "Fiil In The Blanks", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    con.Open();

                    SqlCommand cnn = new SqlCommand("Update MoviesTiketsBookingDetails Set Name=@Name,Date=@Date,Tickets=@Tickets,Price=@Price where BookingId=@BookingId", con);
                    cnn.Parameters.AddWithValue("@BookingId", txt_ID.Text);
                    cnn.Parameters.AddWithValue("@Name", Movie_Title.Text);
                    cnn.Parameters.AddWithValue("@Date", Date.Text);
                    cnn.Parameters.AddWithValue("@Tickets", combobox1.Text);
                    cnn.Parameters.AddWithValue("@Price", txt_total.Text);
                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Your Booking Details Updated", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);

                    BookSeates bookSeates = new BookSeates(Movie_Title.Text, Convert.ToInt32(combobox1.Text), Convert.ToInt32(txt_total.Text), Convert.ToInt32(txt_ID.Text));
                    bookSeates.Show();
                    this.Hide();

                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txt_ID.Text == "")
                {
                    MessageBox.Show("Please Fiil In The Blanks", "Fiil In The Blanks", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    con.Open();

                    SqlCommand cnn = new SqlCommand("Delete MoviesTiketsBookingDetails where BookingId=@BookingId", con);
                    cnn.Parameters.AddWithValue("@BookingId", txt_ID.Text);

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Your Booking Deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxNumbers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox1.SelectedItem != null)
            {
                string selectedValue = combobox1.SelectedItem.ToString();
                int result = 0;

                // Calculation using IF
                if (selectedValue == "1")
                    result = 1 * 500;
                else if (selectedValue == "2")
                    result = 2 * 500;
                else if (selectedValue == "3")
                    result = 3 * 500;
                else if (selectedValue == "4")
                    result = 4 * 500;
                else if (selectedValue == "5")
                    result = 5 * 500;
                else if (selectedValue == "6")
                    result = 6 * 500;
                else if (selectedValue == "7")
                    result = 7 * 500;
                else if (selectedValue == "8")
                    result = 8 * 500;
                else if (selectedValue == "9")
                    result = 9 * 500;
                else if (selectedValue == "10")
                    result = 10 * 500;
                else if (selectedValue == "11")
                    result = 11 * 500;
                else if (selectedValue == "12")
                    result = 12 * 500;
                else if (selectedValue == "13")
                    result = 13 * 500;
                else if (selectedValue == "14")
                    result = 14 * 500;
                else if (selectedValue == "15")
                    result = 15 * 500;
                else if (selectedValue == "16")
                    result = 16 * 500;
                else if (selectedValue == "17")
                    result = 17 * 500;
                else if (selectedValue == "18")
                    result = 18 * 500;
                else if (selectedValue == "19")
                    result = 19 * 500;
                else if (selectedValue == "20")
                    result = 20 * 500;
                else if (selectedValue == "21")
                    result = 21 * 500;
                else if (selectedValue == "22")
                    result = 22 * 500;
                else if (selectedValue == "23")
                    result = 23 * 500;
                else if (selectedValue == "24")
                    result = 24 * 500;
                else if (selectedValue == "25")
                    result = 25 * 500;

                txt_total.Text = result.ToString();

            }
        }
    }

}
