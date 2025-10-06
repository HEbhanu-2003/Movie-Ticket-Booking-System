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
    /// Interaction logic for Payments.xaml
    /// </summary>
    public partial class Payments : Window
    {
        public Payments(int Id,int finalbill)
        {
            InitializeComponent();
            txt_Id.Text = Id.ToString();
            txt_final_bill.Text = finalbill.ToString();
        }

        private void txt_email_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Pay(object sender, RoutedEventArgs e)
        {
            

            try
            {
                if (txt_Email.Text =="" || txt_MobileNumber.Text == "" || txt_CardNumber.Text == "" || txt_CountryOfOrigin.Text == "" || txt_ExpireDate.Text == "" || txt_CVC.Text == "" || txt_BankName.Text == "" || txt_Id.Text == "")
                {
                    MessageBox.Show("Please Fiil In The Blanks", "Fiil In The Blanks", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"Insert Into PaymentsDetails Values (@PaymentId,@Full_Total, @Email, @MobileNumber, @CardNumber, @CountryOfOrigin,@ExpireDate,@CVC,@BranchName)", con);

                    cmd.Parameters.AddWithValue("@PaymentId", txt_Id.Text);
                    cmd.Parameters.AddWithValue("@Full_Total", txt_final_bill.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@MobileNumber", txt_MobileNumber.Text);
                    cmd.Parameters.AddWithValue("@CardNumber", txt_CardNumber.Text);
                    cmd.Parameters.AddWithValue("@CountryOfOrigin", txt_CountryOfOrigin.Text);
                    cmd.Parameters.AddWithValue("@ExpireDate", txt_ExpireDate.Text);
                    cmd.Parameters.AddWithValue("@CVC", txt_CVC.Text);
                    cmd.Parameters.AddWithValue("@BranchName", txt_BankName.Text);
                    cmd.ExecuteNonQuery();

                    this.Hide();
                    Home home = new Home();
                    home.Show();
                    
                    MessageBox.Show("Your Booking Process Succefully !!!.Enjoy Your Movie", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                   
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txt_Email.Text = "";
            txt_MobileNumber.Text = "";
            txt_CardNumber.Text = "";
            txt_CountryOfOrigin.Text = "";
            txt_ExpireDate.Text = "";
            txt_CVC.Text = "";
            txt_BankName.Text = "";
        }

        private void txt_final_bill_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void back(object sender, RoutedEventArgs e)
        {
            Add_Food_Drinks add_Food_Drinks = new Add_Food_Drinks(Convert.ToInt32(txt_Id.Text), Convert.ToInt32(txt_final_bill.Text));
            add_Food_Drinks.Show();
            this.Hide();
        }
    }
}
