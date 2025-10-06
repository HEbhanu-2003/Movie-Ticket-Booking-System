using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadGrid();
            LoadGrid2();
            LoadGrid3();
            LoadGrid4();
        }

        public void LoadGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                con.Open();
                SqlCommand cnn = new SqlCommand("Select * From MoviesTiketsBookingDetails", con);
                SqlDataReader sqlDataReader = cnn.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                con.Close();
                DataGrid1.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void LoadGrid2()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True");
                con.Open();
                SqlCommand cnn = new SqlCommand("Select * From Registration_Details", con);
                SqlDataReader sqlDataReader = cnn.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                con.Close();
                DataGrid3.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void LoadGrid3()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                con.Open();
                SqlCommand cnn = new SqlCommand("Select * From PaymentsDetails", con);
                SqlDataReader sqlDataReader = cnn.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                con.Close();
                DataGrid2.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void LoadGrid4()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                con.Open();
                SqlCommand cnn = new SqlCommand("Select * From Select_Food_AND_Drinks_Price_Details ", con);
                SqlDataReader sqlDataReader = cnn.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                con.Close();
                DataGrid4.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exite(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Report_View(object sender, RoutedEventArgs e)
        {

        }

        private void Report_View_1(object sender, RoutedEventArgs e)
        {
            if (DataGrid3.Items.Count == 0 && DataGrid1.Items.Count == 0 && DataGrid4.Items.Count == 0 && DataGrid2.Items.Count == 0)
            {
                MessageBox.Show("No Record Found", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Final Report";

            if (save.ShowDialog() == true)
            {
                try
                {
                    PdfPTable pTable = new PdfPTable(DataGrid3.Columns.Count);
                    PdfPTable pTable1 = new PdfPTable(DataGrid1.Columns.Count);
                    PdfPTable pTable3 = new PdfPTable(DataGrid4.Columns.Count);
                    PdfPTable pTable2 = new PdfPTable(DataGrid2.Columns.Count);
                    pTable.DefaultCell.Padding = 3;
                    pTable.WidthPercentage = 100;
                    pTable1.DefaultCell.Padding = 3;
                    pTable1.WidthPercentage = 100;
                    pTable3.DefaultCell.Padding = 3;
                    pTable3.WidthPercentage = 100;
                    pTable2.DefaultCell.Padding = 3;
                    pTable2.WidthPercentage = 100;

                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pTable1.HorizontalAlignment = Element.ALIGN_LEFT;
                    pTable3.HorizontalAlignment = Element.ALIGN_LEFT;
                    pTable2.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (var col in DataGrid3.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable.AddCell(pCell);
                    }
                    foreach (var col in DataGrid1.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable1.AddCell(pCell);
                    }
                    foreach (var col in DataGrid4.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable3.AddCell(pCell);
                    }
                    foreach (var col in DataGrid2.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable2.AddCell(pCell);
                    }

                    
                    foreach (var item in DataGrid3.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid3.Columns)
                        {
                     
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable.AddCell(cellValue);
                        }
                    }
                    foreach (var item in DataGrid1.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid1.Columns)
                        {
                            
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable1.AddCell(cellValue);
                        }
                    }
                    foreach (var item in DataGrid4.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid4.Columns)
                        {

                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable3.AddCell(cellValue);
                        }
                    }
                    foreach (var item in DataGrid2.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid2.Columns)
                        {
                            
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable2.AddCell(cellValue);
                        }
                    }

                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        document.Add(pTable);
                        document.Add(pTable1);
                        document.Add(pTable3);
                        document.Add(pTable2);
                        document.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Data Exported Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data", MessageBoxImage.Error + ex.Message);
                }
            }

        }
        private void Income_View_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double total = 0, total2 = 0,income = 0;

                foreach (var item in DataGrid1.Items)
                {
                    if (item is System.Data.DataRowView row)
                    {
                        if (row[4] != DBNull.Value && double.TryParse(row[4].ToString(), out double value))
                        {
                            total += value;
                        }
                    }
                }
                foreach (var item in DataGrid4.Items)
                {
                    if (item is System.Data.DataRowView row)
                    {
                        if (row[1] != DBNull.Value && double.TryParse(row[1].ToString(), out double value))
                        {
                            total2 += value;
                        }
                    }
                }
                income = total + total2;
                txt_Income.Content = income.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txt_Income_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ExportToPDF_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid3.Items.Count == 0)
            {
                MessageBox.Show("No Record Found", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Registration Details";

            if (save.ShowDialog() == true)
            {
                try
                {
                    PdfPTable pTable = new PdfPTable(DataGrid3.Columns.Count);
                    pTable.DefaultCell.Padding = 3;
                    pTable.WidthPercentage = 100;
                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                   
                    foreach (var col in DataGrid3.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable.AddCell(pCell);
                    }

                    
                    foreach (var item in DataGrid3.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid3.Columns)
                        {
                           
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable.AddCell(cellValue);
                        }
                    }

                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        document.Add(pTable);
                        document.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Data Exported Successfully", "Info",MessageBoxButton.OK,MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data",MessageBoxImage.Error + ex.Message);
                }
            }
        }

        private void ExportToPDF2_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid2.Items.Count == 0)
            {
                MessageBox.Show("No Record Found", "Info",MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Payments Details";

            if (save.ShowDialog() == true)
            {
                try
                {
                    PdfPTable pTable = new PdfPTable(DataGrid2.Columns.Count);
                    pTable.DefaultCell.Padding = 3;
                    pTable.WidthPercentage = 100;
                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    
                    foreach (var col in DataGrid2.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable.AddCell(pCell);
                    }
                    
                    foreach (var item in DataGrid2.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid2.Columns)
                        {
                         
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable.AddCell(cellValue);
                        }
                    }

                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        document.Add(pTable);
                        document.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Data Exported Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data", MessageBoxImage.Error + ex.Message);
                }
            }
        }

        private void ExportToPDF3_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid1.Items.Count == 0)
            {
                MessageBox.Show("No Record Found", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Tickets Booking Details";

            if (save.ShowDialog() == true)
            {
                try
                {
                    PdfPTable pTable = new PdfPTable(DataGrid1.Columns.Count);
                    pTable.DefaultCell.Padding = 3;
                    pTable.WidthPercentage = 100;
                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                  
                    foreach (var col in DataGrid1.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable.AddCell(pCell);
                    }
                   
                    foreach (var item in DataGrid1.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid1.Columns)
                        {
                           
                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable.AddCell(cellValue);
                        }
                    }

                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        document.Add(pTable);
                        document.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Data Exported Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data", MessageBoxImage.Error + ex.Message);
                }
            }
        }

        private void ExportToPDF4_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid4.Items.Count == 0)
            {
                MessageBox.Show("No Record Found", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Food & Drinks Adding Details";

            if (save.ShowDialog() == true)
            {
                try
                {
                    PdfPTable pTable = new PdfPTable(DataGrid4.Columns.Count);
                    pTable.DefaultCell.Padding = 3;
                    pTable.WidthPercentage = 100;
                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;


                    foreach (var col in DataGrid4.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.Header.ToString()))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pTable.AddCell(pCell);
                    }

                    foreach (var item in DataGrid4.Items)
                    {
                        if (item == null) continue;

                        foreach (var col in DataGrid4.Columns)
                        {

                            var cellContent = col.GetCellContent(item) as TextBlock;
                            string cellValue = cellContent != null ? cellContent.Text : "";
                            pTable.AddCell(cellValue);
                        }
                    }

                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        document.Add(pTable);
                        document.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Data Exported Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data", MessageBoxImage.Error + ex.Message);
                }
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {

            try
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("Please First Enter Customr ID Search Filled And After Click Search Button", "Enter", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True");
                    SqlCommand command1 = new SqlCommand("select * from Registration_Details where RegisterId='" + (txt_Search.Text) + "' ",con1);

                    SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    SqlCommand command2 = new SqlCommand("select * from MoviesTiketsBookingDetails where BookingId='" + (txt_Search.Text) + "' ",con2);

                    SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    SqlCommand command3 = new SqlCommand("select * from Select_Food_AND_Drinks_Price_Details where Selected_Items_ID='" + (txt_Search.Text) + "' ",con3);

                    SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    SqlCommand command4 = new SqlCommand("select * from PaymentsDetails where PaymentId='" + (txt_Search.Text) + "' ",con4);


                    SqlDataAdapter sd1 = new SqlDataAdapter(command1);
                    DataTable dt1 = new DataTable();
                    sd1.Fill(dt1);
                    DataGrid3.ItemsSource = dt1.DefaultView;

                    SqlDataAdapter sd2 = new SqlDataAdapter(command2);
                    DataTable dt2 = new DataTable();
                    sd2.Fill(dt2);
                    DataGrid1.ItemsSource = dt2.DefaultView;

                    SqlDataAdapter sd3 = new SqlDataAdapter(command3);
                    DataTable dt3 = new DataTable();
                    sd3.Fill(dt3);
                    DataGrid4.ItemsSource = dt3.DefaultView;

                    SqlDataAdapter sd4 = new SqlDataAdapter(command4);
                    DataTable dt4 = new DataTable();
                    sd4.Fill(dt4);
                    DataGrid2.ItemsSource = dt4.DefaultView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txt_Search.Text = "";
            txt_Income.Content = "";

            DataGrid1.ItemsSource= null;
            DataGrid2.ItemsSource = null;
            DataGrid3.ItemsSource = null;
            DataGrid4.ItemsSource = null;
        }

        private void View_all_data_1(object sender, RoutedEventArgs e)
        {
            LoadGrid();
            LoadGrid2();
            LoadGrid3();
            LoadGrid4();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txt_Search.Text == "")
                {
                    MessageBox.Show("Please First Enter Customr ID Search Filled And After Click Delete Button", "Enter", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {
                    SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    con1.Open();

                    SqlCommand cnn1 = new SqlCommand("Delete MoviesTiketsBookingDetails where BookingId=@BookingId", con1);
                    SqlCommand cnn2 = new SqlCommand("Delete Select_Food_AND_Drinks_Price_Details where Selected_Items_ID=@Selected_Items_ID", con1);
                    SqlCommand cnn3 = new SqlCommand("Delete PaymentsDetails where PaymentId=@PaymentId", con1);

                    cnn1.Parameters.AddWithValue("@BookingId", txt_Search.Text);
                    cnn2.Parameters.AddWithValue("@Selected_Items_ID", txt_Search.Text);
                    cnn3.Parameters.AddWithValue("@PaymentId", txt_Search.Text);

                    SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True");
                    con2.Open();

                    SqlCommand cnn4 = new SqlCommand("Delete Registration_Details where RegisterId=@RegisterId", con2);
                    cnn4.Parameters.AddWithValue("@RegisterId", txt_Search.Text);

                    cnn1.ExecuteNonQuery();
                    cnn2.ExecuteNonQuery();
                    cnn3.ExecuteNonQuery();
                    cnn4.ExecuteNonQuery();

                    MessageBox.Show("Customer Registration & Booking Details Deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

                    con1.Close();
                    con2.Close();
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Reset_All_Customers_data(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Are You Sure Rest All Data !!!", "Think Again", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=BookTicket;Integrated Security=True");
                    con1.Open();

                    SqlCommand cnn1 = new SqlCommand("Delete From MoviesTiketsBookingDetails", con1);
                    SqlCommand cnn2 = new SqlCommand("Delete From Select_Food_AND_Drinks_Price_Details", con1);
                    SqlCommand cnn3 = new SqlCommand("Delete From PaymentsDetails", con1);

                    SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-ABKRPIF;Initial Catalog=Registration1;Integrated Security=True");
                    con2.Open();

                    SqlCommand cnn4 = new SqlCommand("Delete From Registration_Details", con2);

                    cnn1.ExecuteNonQuery();
                    cnn2.ExecuteNonQuery();
                    cnn3.ExecuteNonQuery();
                    cnn4.ExecuteNonQuery();

                    MessageBox.Show("Movie Ticket Booking System All Data Deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

                    txt_Search.Text = "";
                    txt_Income.Content = "";
                    DataGrid1.ItemsSource = null;
                    DataGrid2.ItemsSource = null;
                    DataGrid3.ItemsSource = null;
                    DataGrid4.ItemsSource = null;

                    con1.Close();
                    con2.Close();
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
