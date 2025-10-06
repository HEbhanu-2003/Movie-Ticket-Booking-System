using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for BookSeates.xaml
    /// </summary>
    public partial class BookSeates : Window
    {
        public BookSeates(string MovieName, int tickets, int amount,int Id)
        {
            InitializeComponent();
            txt_movietitle.Text = MovieName;
            txt_tickets.Text = tickets.ToString();
            txt_amount.Text = amount.ToString();
            txt_Id.Text = Id.ToString();
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            Add_Food_Drinks add_Food_Drinks = new Add_Food_Drinks(Convert.ToInt32(txt_Id.Text), Convert.ToInt32(txt_amount.Text));
            add_Food_Drinks.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quick Book Your Seates Now !!!","Book",MessageBoxButton.OK,MessageBoxImage.Information);
            Screen.Background = Brushes.Green;
        }

        private void A_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "1")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_1.Background = Brushes.Red;
                    }
                    else
                    {
                        A_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("1");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.","",MessageBoxButton.OK,MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void A_2_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "2")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_2.Background = Brushes.Red;
                    }
                    else
                    {
                        A_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("2");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

 
        }

        private void A_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    if (txt_movietitle.Text == "Nelumkuluna")
                    {
                        string file = "Nelumkuluna.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;

                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Mandara")
                    {
                        string file = "Mandara.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;
                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Kasiwasi")
                    {
                        string file = "Kasiwasi.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;
                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "House Full")
                    {
                        string file = "House Full.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;
                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Dewikusumasana")
                    {
                        string file = "Dewikusumasana.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;
                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information); ;
                        }
                    }
                    if (txt_movietitle.Text == "Walampuri")
                    {
                        string file = "Walampuri.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "3")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_3.Background = Brushes.Red;
                        }
                        else
                        {
                            A_3.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("3");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void A_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    if (txt_movietitle.Text == "Nelumkuluna")
                    {
                        string file = "Nelumkuluna.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Mandara")
                    {
                        string file = "Mandara.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Kasiwasi")
                    {
                        string file = "Kasiwasi.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "House Full")
                    {
                        string file = "House Full.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Dewikusumasana")
                    {
                        string file = "Dewikusumasana.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    if (txt_movietitle.Text == "Walampuri")
                    {
                        string file = "Walampuri.txt";
                        string[] files = File.ReadAllLines(file);

                        int count2 = 0;

                        foreach (string i in files)
                        {
                            if (i == "4")
                            {
                                count2++;
                            }
                        }
                        if (count2 > 0)
                        {
                            MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            A_4.Background = Brushes.Red;
                        }
                        else
                        {
                            A_4.Background = Brushes.Green;
                            List<string> filess2 = File.ReadAllLines(file).ToList();
                            filess2.Add("4");
                            File.WriteAllLines(file, filess2);

                            MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void A_5_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;
                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;

                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;
                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;

                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;

                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "5")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        A_5.Background = Brushes.Red;

                    }
                    else
                    {
                        A_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("5");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void B_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;
                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;

                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;
                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;

                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;

                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "6")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_1.Background = Brushes.Red;

                    }
                    else
                    {
                        B_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("6");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void B_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;
                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;

                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;
                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;

                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;

                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "7")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_2.Background = Brushes.Red;

                    }
                    else
                    {
                        B_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("7");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void B_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "8")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("8");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void B_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "9")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("9");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

                if (txt_movietitle.Text == "Mandara")
            {
                string file = "Mandara.txt";
                string[] files = File.ReadAllLines(file);

                int count2 = 0;

                foreach (string i in files)
                {
                    if (i == "9")
                    {
                        count2++;
                    }
                }
                if (count2 > 0)
                {
                    MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    B_4.Background=( Brushes.Red);

                }
                else
                {
                    B_4.Background = Brushes.Green;
                    List<string> filess2 = File.ReadAllLines(file).ToList();
                    filess2.Add("9");
                    File.WriteAllLines(file, filess2);

                    MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            if (txt_movietitle.Text == "Kasiwasi")
            {
                string file = "Kasiwasi.txt";
                string[] files = File.ReadAllLines(file);

                int count2 = 0;

                foreach (string i in files)
                {
                    if (i == "9")
                    {
                        count2++;
                    }
                }
                if (count2 > 0)
                {
                    MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    B_4.Background=( Brushes.Red);
                }
                else
                {
                    B_4.Background = Brushes.Green;
                    List<string> filess2 = File.ReadAllLines(file).ToList();
                    filess2.Add("9");
                    File.WriteAllLines(file, filess2);

                    MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            if (txt_movietitle.Text == "House Full")
            {
                string file = "House Full.txt";
                string[] files = File.ReadAllLines(file);

                int count2 = 0;

                foreach (string i in files)
                {
                    if (i == "9")
                    {
                        count2++;
                    }
                }
                if (count2 > 0)
                {
                    MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    B_4.Background=( Brushes.Red);

                }
                else
                {
                    B_4.Background = Brushes.Green;
                    List<string> filess2 = File.ReadAllLines(file).ToList();
                    filess2.Add("9");
                    File.WriteAllLines(file, filess2);

                    MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            if (txt_movietitle.Text == "Dewikusumasana")
            {
                string file = "Dewikusumasana.txt";
                string[] files = File.ReadAllLines(file);

                int count2 = 0;

                foreach (string i in files)
                {
                    if (i == "9")
                    {
                        count2++;
                    }
                }
                if (count2 > 0)
                {
                    MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    B_4.Background=( Brushes.Red);

                }
                else
                {
                    B_4.Background = Brushes.Green;
                    List<string> filess2 = File.ReadAllLines(file).ToList();
                    filess2.Add("9");
                    File.WriteAllLines(file, filess2);

                    MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            if (txt_movietitle.Text == "Walampuri")
            {
                string file = "Walampuri.txt";
                string[] files = File.ReadAllLines(file);

                int count2 = 0;

                foreach (string i in files)
                {
                    if (i == "9")
                    {
                        count2++;
                    }
                }
                if (count2 > 0)
                {
                    MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    B_4.Background=( Brushes.Red);

                }
                else
                {
                    B_4.Background = Brushes.Green;
                    List<string> filess2 = File.ReadAllLines(file).ToList();
                    filess2.Add("9");
                    File.WriteAllLines(file, filess2);

                    MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void B_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "10")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        B_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        B_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("10");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void C_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "11")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("11");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void C_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "12")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("12");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void C_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "13")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("13");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void C_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "14")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("14");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void C_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "15")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        C_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        C_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("15");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void D_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "16")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("16");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void D_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "17")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("17");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void D_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "18")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("18");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void D_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "19")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("19");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void D_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "20")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        D_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        D_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("20");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void E_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "21")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_1.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_1.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("21");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void E_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "22")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_2.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_2.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("22");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void E_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "23")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_3.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_3.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("23");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void E_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "24")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_4.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_4.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("24");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void E_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_movietitle.Text == "Nelumkuluna")
                {
                    string file = "Nelumkuluna.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Mandara")
                {
                    string file = "Mandara.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Kasiwasi")
                {
                    string file = "Kasiwasi.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);
                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "House Full")
                {
                    string file = "House Full.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Dewikusumasana")
                {
                    string file = "Dewikusumasana.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (txt_movietitle.Text == "Walampuri")
                {
                    string file = "Walampuri.txt";
                    string[] files = File.ReadAllLines(file);

                    int count2 = 0;

                    foreach (string i in files)
                    {
                        if (i == "25")
                        {
                            count2++;
                        }
                    }
                    if (count2 > 0)
                    {
                        MessageBox.Show("This is already Taken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        E_5.Background = (Brushes.Red);

                    }
                    else
                    {
                        E_5.Background = Brushes.Green;
                        List<string> filess2 = File.ReadAllLines(file).ToList();
                        filess2.Add("25");
                        File.WriteAllLines(file, filess2);

                        MessageBox.Show("Reserved Successfully! Thank you.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

 
        }
    }
}

