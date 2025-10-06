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
    /// Interaction logic for Add_Food_Drinks.xaml
    /// </summary>
    public partial class Add_Food_Drinks : Window
    {
        public Add_Food_Drinks(int Id,int ticketsAmount)
        {
            InitializeComponent();
            txt_Id.Text = Id.ToString();
            txt_tickets_amount.Text = ticketsAmount.ToString();
            txt_total.Text = ticketsAmount.ToString();

            int[] numbers = {0 ,1, 2, 3, 4, 5 ,6 ,7 ,8 ,9 ,10 ,11 ,12 ,13,14,15,16,17,18,19,20,21,22,23,24,25};
            Combox1.ItemsSource = numbers;
            Combox2.ItemsSource = numbers;
            Combox3.ItemsSource = numbers;
            Combox4.ItemsSource = numbers;
            Combox5.ItemsSource = numbers;
            Combox6.ItemsSource = numbers;
        }

        private void txt_Id_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int val1 = 0, val2 = 0, val3 = 0, val4 = 0, val5 = 0, val6 = 0;
            

            if (Combox1.SelectedItem != null)
            {
                int sel = (int)Combox1.SelectedItem;
                if (sel == 0) val1 = 0 * 000;
                if (sel == 1) val1 = 1 * 550;
                if (sel == 2) val1 = 2 * 550;
                if (sel == 3) val1 = 3 * 550;
                if (sel == 4) val1 = 4 * 550;
                if (sel == 5) val1 = 5 * 550;
                if (sel == 6) val1 = 6 * 550;
                if (sel == 7) val1 = 7 * 550;
                if (sel == 8) val1 = 8 * 550;
                if (sel == 9) val1 = 9 * 550;
                if (sel == 10) val1 = 10 * 550;
                if (sel == 11) val1 = 11 * 550;
                if (sel == 12) val1 = 12 * 550;
                if (sel == 13) val1 = 13 * 550;
                if (sel == 14) val1 = 14 * 550;
                if (sel == 15) val1 = 15 * 550;
                if (sel == 16) val1 = 16 * 550;
                if (sel == 17) val1 = 17 * 550;
                if (sel == 18) val1 = 18 * 550;
                if (sel == 19) val1 = 19 * 550;
                if (sel == 20) val1 = 20 * 550;
                if (sel == 21) val1 = 21 * 550;
                if (sel == 22) val1 = 22 * 550;
                if (sel == 23) val1 = 23 * 550;
                if (sel == 24) val1 = 24 * 550;
                if (sel == 25) val1 = 25 * 550;


            }

            if (Combox2.SelectedItem != null)
            {
                int sel = (int)Combox2.SelectedItem;
                if (sel == 0) val2 = 0 * 000;
                if (sel == 1) val2 = 1 * 475;
                if (sel == 2) val2 = 2 * 475;
                if (sel == 3) val2 = 3 * 475;
                if (sel == 4) val2 = 4 * 475;
                if (sel == 5) val2 = 5 * 475;
                if (sel == 6) val2 = 6 * 475;
                if (sel == 7) val2 = 7 * 475;
                if (sel == 8) val2 = 8 * 475;
                if (sel == 9) val2 = 9 * 475;
                if (sel == 10) val2 = 10 * 475;
                if (sel == 11) val2 = 11 * 475;
                if (sel == 12) val2 = 12 * 475;
                if (sel == 13) val2 = 13 * 475;
                if (sel == 14) val2 = 14 * 475;
                if (sel == 15) val2 = 15 * 475;
                if (sel == 16) val2 = 16 * 475;
                if (sel == 17) val2 = 17 * 475;
                if (sel == 18) val2 = 18 * 475;
                if (sel == 19) val2 = 19 * 475;
                if (sel == 20) val2 = 20 * 475;
                if (sel == 21) val2 = 21 * 475;
                if (sel == 22) val2 = 22 * 475;
                if (sel == 23) val2 = 23 * 475;
                if (sel == 24) val2 = 24 * 475;
                if (sel == 25) val2 = 25 * 475;
            }

            if (Combox3.SelectedItem != null)
            {
                int sel = (int)Combox3.SelectedItem;
                if (sel == 0) val3 = 0 * 000;
                if (sel == 1) val3 = 1 * 75;
                if (sel == 2) val3 = 2 * 75;
                if (sel == 3) val3 = 3 * 75;
                if (sel == 4) val3 = 4 * 75;
                if (sel == 5) val3 = 5 * 75;
                if (sel == 6) val3 = 6 * 75;
                if (sel == 7) val3 = 7 * 75;
                if (sel == 8) val3 = 8 * 75;
                if (sel == 9) val3 = 9 * 75;
                if (sel == 10) val3 = 10 * 75;
                if (sel == 11) val3 = 11 * 75;
                if (sel == 12) val3 = 12 * 75;
                if (sel == 13) val3 = 13 * 75;
                if (sel == 14) val3 = 14 * 75;
                if (sel == 15) val3 = 15 * 75;
                if (sel == 16) val3 = 16 * 75;
                if (sel == 17) val3 = 17 * 75;
                if (sel == 18) val3 = 18 * 75;
                if (sel == 19) val3 = 19 * 75;
                if (sel == 20) val3 = 20 * 75;
                if (sel == 21) val3 = 21 * 75;
                if (sel == 22) val3 = 22 * 75;
                if (sel == 23) val3 = 23 * 75;
                if (sel == 24) val3 = 24 * 75;
                if (sel == 25) val3 = 25 * 75;
                
            }

            if (Combox4.SelectedItem != null)
            {
                int sel = (int)Combox4.SelectedItem;
                if (sel == 0) val4 = 0 * 000;
                if (sel == 1) val4 = 1 * 150;
                if (sel == 2) val4 = 2 * 150;
                if (sel == 3) val4 = 3 * 150;
                if (sel == 4) val4 = 4 * 150;
                if (sel == 5) val4 = 5 * 150;
                if (sel == 6) val4 = 6 * 150;
                if (sel == 7) val4 = 7 * 150;
                if (sel == 8) val4 = 8 * 150;
                if (sel == 9) val4 = 9 * 150;
                if (sel == 10) val4 = 10 * 150;
                if (sel == 11) val4 = 11 * 150;
                if (sel == 12) val4 = 12 * 150;
                if (sel == 13) val4 = 13 * 150;
                if (sel == 14) val4 = 14 * 150;
                if (sel == 15) val4 = 15 * 150;
                if (sel == 16) val4 = 16 * 150;
                if (sel == 17) val4 = 17 * 150;
                if (sel == 18) val4 = 18 * 150;
                if (sel == 19) val4 = 19 * 150;
                if (sel == 20) val4 = 20 * 150;
                if (sel == 21) val4 = 21 * 150;
                if (sel == 22) val4 = 22 * 150; 
                if (sel == 23) val4 = 23 * 150;
                if (sel == 24) val4 = 24 * 150;
                if (sel == 25) val4 = 25 * 150;
            }

            if (Combox5.SelectedItem != null)
            {
                int sel = (int)Combox5.SelectedItem;
                if (sel == 0) val5 = 0 * 000;
                if (sel == 1) val5 = 1 * 175;
                if (sel == 2) val5 = 2 * 175;
                if (sel == 3) val5 = 3 * 175;
                if (sel == 4) val5 = 4 * 175;
                if (sel == 5) val5 = 5 * 175;
                if (sel == 6) val5 = 6 * 175;
                if (sel == 7) val5 = 7 * 175;
                if (sel == 8) val5 = 8 * 175;
                if (sel == 9) val5 = 9 * 175;
                if (sel == 10) val5 = 10 * 175;
                if (sel == 11) val5 = 11 * 175;
                if (sel == 12) val5 = 12 * 175;
                if (sel == 13) val5 = 13 * 175;
                if (sel == 14) val5 = 14 * 175;
                if (sel == 15) val5 = 15 * 175;
                if (sel == 16) val5 = 16 * 175;
                if (sel == 17) val5 = 17 * 175;
                if (sel == 18) val5 = 18 * 175;
                if (sel == 19) val5 = 19 * 175;
                if (sel == 20) val5 = 20 * 175;
                if (sel == 21) val5 = 21 * 175;
                if (sel == 22) val5 = 22 * 175;
                if (sel == 23) val5 = 23 * 175;
                if (sel == 24) val5 = 24 * 175;
                if (sel == 25) val5 = 25 * 175;
            }

            if (Combox6.SelectedItem != null)
            {
                int sel = (int)Combox6.SelectedItem;
                if (sel == 0) val6 = 0 * 000;
                if (sel == 1) val6 = 1 * 1200;
                if (sel == 2) val6 = 2 * 1200;
                if (sel == 3) val6 = 3 * 1200;
                if (sel == 4) val6 = 4 * 1200;
                if (sel == 5) val6 = 5 * 1200;
                if (sel == 6) val6 = 6 * 1200;
                if (sel == 7) val6 = 7 * 1200;
                if (sel == 8) val6 = 8 * 1200;
                if (sel == 9) val6 = 9 * 1200;
                if (sel == 10) val6 = 10 * 1200;
                if (sel == 11) val6 = 11 * 1200;
                if (sel == 12) val6 = 12 * 1200;
                if (sel == 13) val6 = 13 * 1200;
                if (sel == 14) val6 = 14 * 1200;
                if (sel == 15) val6 = 15 * 1200;
                if (sel == 16) val6 = 16 * 1200;
                if (sel == 17) val6 = 17 * 1200;
                if (sel == 18) val6 = 18 * 1200;
                if (sel == 19) val6 = 19 * 1200;
                if (sel == 20) val6 = 20 * 1200;
                if (sel == 21) val6 = 21 * 1200;
                if (sel == 22) val6 = 22 * 1200;
                if (sel == 23) val6 = 23 * 1200;
                if (sel == 24) val6 = 24 * 1200;
                if (sel == 25) val6 = 25 * 1200;
            }

            int total,itemprice;
             total = val1 + val2 + val3 + val4 + val5 + val6;
             itemprice = total;

            if (int.TryParse(txt_tickets_amount.Text, out int ticketAmount))
            {
                total += ticketAmount;
            }
            else
            {
                MessageBox.Show("Invalid number in Tickets Amount box");
            }

            txt_total.Text = total.ToString();
            txt_select_item_price.Text = itemprice.ToString();
        }

        private void Skeep_Payment_Click(object sender, RoutedEventArgs e)
        {

            if ((Combox1.Text == "" || Combox1.Text == "0") &&
                (Combox2.Text == "" || Combox2.Text == "0") &&
                (Combox3.Text == "" || Combox3.Text == "0") &&
                (Combox4.Text == "" || Combox4.Text == "0") &&
                (Combox5.Text == "" || Combox5.Text == "0") &&
                (Combox6.Text == "" || Combox6.Text == "0"))
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you don't want to add Food & Drinks to your booking?","Confirm",MessageBoxButton.YesNo,MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Payments payments = new Payments(Convert.ToInt32(txt_Id.Text), Convert.ToInt32(txt_total.Text));
                    payments.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please add your selected Food & Drinks by clicking the ADD ITEM button.","Reminder",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True"))
            {
                con.Open();

                if ((Combox1.Text == "" || Combox1.Text == "0") &&
                    (Combox2.Text == "" || Combox2.Text == "0") &&
                    (Combox3.Text == "" || Combox3.Text == "0") &&
                    (Combox4.Text == "" || Combox4.Text == "0") &&
                    (Combox5.Text == "" || Combox5.Text == "0") &&
                    (Combox6.Text == "" || Combox6.Text == "0"))
                {
                    MessageBox.Show("Select Food Or Drinks Items", "Selected", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                SqlCommand cmd1 = new SqlCommand(@"IF EXISTS (SELECT 1 FROM Select_Food_AND_Drinks_Price_Details WHERE Selected_Items_ID = @Selected_Items_ID) UPDATE Select_Food_AND_Drinks_Price_Details SET Items_Price = @Items_Price WHERE Selected_Items_ID = @Selected_Items_ID ELSE INSERT INTO Select_Food_AND_Drinks_Price_Details (Selected_Items_ID, Items_Price) VALUES (@Selected_Items_ID, @Items_Price)", con);

                cmd1.Parameters.AddWithValue("@Selected_Items_ID", txt_Id.Text);
                cmd1.Parameters.AddWithValue("@Items_Price", txt_select_item_price.Text);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Your Food & Drinks Items Added To Your Booking","Booked", MessageBoxButton.OK, MessageBoxImage.Information);

                Payments payments = new Payments(Convert.ToInt32(txt_Id.Text),Convert.ToInt32(txt_total.Text));

                payments.Show();
                this.Hide();
            }


        }
    }
}
