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
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace ITMO.ADO.NET.ControlLab_4
{

    public partial class OrdersViewer : Window
    {
        NorthwindDataSet northwindDataset;
        SqlConnection northwindConnection;
        SqlDataAdapter sqlDataAdapter;
        public OrdersViewer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            northwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            northwindDataset = new NorthwindDataSet();
            string query = "SELECT * FROM Orders";
            sqlDataAdapter = new SqlDataAdapter(query, northwindConnection);
            sqlDataAdapter.Fill(northwindDataset, "Orders");
            dataGrid.ItemsSource = northwindDataset.Tables["Orders"].DefaultView;
            northwindConnection.Close();
        }

        private void getOrd_btn_Click(object sender, RoutedEventArgs e)
        {
            northwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            northwindDataset = new NorthwindDataSet();
            string query = "SELECT * FROM Orders";
            sqlDataAdapter = new SqlDataAdapter(query, northwindConnection);
            sqlDataAdapter.Fill(northwindDataset, "Orders");
            northwindDataset.EndInit();
            sqlDataAdapter.Update(northwindDataset.Tables["Orders"]);
            dataGrid.ItemsSource = northwindDataset.Tables["Orders"].DefaultView;
            northwindConnection.Close();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            northwindDataset.EndInit();
            var index = dataGrid.Items.IndexOf(dataGrid.SelectedCells);
            northwindDataset.Tables["Orders"].Rows[index].Delete();
            sqlDataAdapter.Update(northwindDataset.Tables["Orders"]);
        }

        private void newOrder_btn_Click(object sender, RoutedEventArgs e)
        {
            OrderingWindow order = new OrderingWindow();
            order.Show();
        }
    }

}
