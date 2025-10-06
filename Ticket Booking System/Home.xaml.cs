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

namespace Ticket_Booking_System
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            
        }
        public static string passingTitle;

        private void Movie_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("Kasiwasi");
            passingTitle = "Kasiwasi";
            booking.Show();
            this.Close();
        }

        private void Movie_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("Nelumkuluna");
            passingTitle = "Nelumkuluna";
            booking.Show();
            this.Close();
        }

        private void Movie_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("Mandara");
            passingTitle = "Mandara";
            booking.Show();
            this.Close();
        }

        private void Movie_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("House Full");
            passingTitle = "House Full";
            booking.Show();
            this.Close();
        }

        private void Movie_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("Dewikusumasana");
            passingTitle = "Dewikusumasana";
            booking.Show();
            this.Close();
        }

        private void Movie_6(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking booking = new Booking("Walampuri");
            passingTitle = "Walampuri";
            booking.Show();
            this.Close();
        }

        private void Exite(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
