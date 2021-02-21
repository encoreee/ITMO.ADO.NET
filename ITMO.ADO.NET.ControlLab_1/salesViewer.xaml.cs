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

namespace ITMO.ADO.NET.ControlLab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class salesViewer : Window
    {


        public salesViewer()
        {
            InitializeComponent();
        }

        private void ShowMonthSales_Click(object sender, RoutedEventArgs e)
        {
            DateTime monthBefore = DateTime.Today.AddMonths(-1);
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            var cmd = new SqlCommand(
                " SELECT Sales.SalesOrderHeader.SalesOrderID, Sales.SalesOrderHeader.RevisionNumber, Sales.SalesOrderHeader.OrderDate, Sales.SalesOrderHeader.DueDate, Sales.SalesOrderHeader.ShipDate, " +
                " Sales.SalesOrderHeader.TotalDue, Sales.SalesOrderHeader.ShipToAddressID, Sales.SalesOrderHeader.BillToAddressID, Sales.Customer.AccountNumber " +
                " FROM  Sales.SalesOrderHeader INNER JOIN " +
                " Sales.Customer ON Sales.SalesOrderHeader.CustomerID = Sales.Customer.CustomerID INNER JOIN " +
                " Sales.SalesPerson ON Sales.SalesOrderHeader.SalesPersonID = Sales.SalesPerson.BusinessEntityID " +
                " where Sales.SalesOrderHeader.OrderDate >= @date", con);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = monthBefore;
            ModelCollection dt = new ModelCollection(cmd, con);
            dataGrid.ItemsSource = dt;
        }

        private void SalesViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ShowQuorterSales_Click(object sender, RoutedEventArgs e)
        {
            DateTime monthBefore = DateTime.Today.AddMonths(-3);
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            var cmd = new SqlCommand(
                " SELECT Sales.SalesOrderHeader.SalesOrderID, Sales.SalesOrderHeader.RevisionNumber, Sales.SalesOrderHeader.OrderDate, Sales.SalesOrderHeader.DueDate, Sales.SalesOrderHeader.ShipDate, " +
                " Sales.SalesOrderHeader.TotalDue, Sales.SalesOrderHeader.ShipToAddressID, Sales.SalesOrderHeader.BillToAddressID, Sales.Customer.AccountNumber " +
                " FROM  Sales.SalesOrderHeader INNER JOIN " +
                " Sales.Customer ON Sales.SalesOrderHeader.CustomerID = Sales.Customer.CustomerID INNER JOIN " +
                " Sales.SalesPerson ON Sales.SalesOrderHeader.SalesPersonID = Sales.SalesPerson.BusinessEntityID " +
                " where Sales.SalesOrderHeader.OrderDate >= @date", con);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = monthBefore;
            ModelCollection dt = new ModelCollection(cmd, con);
            dataGrid.ItemsSource = dt;
        }

        private void ShowSelectedDates_Click(object sender, RoutedEventArgs e)
        {
            DateTime? startOfPeriod = this.datePickerStart.SelectedDate;
            DateTime? endOfPeriod = this.datePickerEnd.SelectedDate;
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            var cmd = new SqlCommand(
                " SELECT Sales.SalesOrderHeader.SalesOrderID, Sales.SalesOrderHeader.OrderDate, Sales.SalesOrderHeader.DueDate, Sales.SalesOrderHeader.ShipDate, " +
                " Sales.SalesOrderHeader.TotalDue, Sales.SalesOrderHeader.ShipToAddressID, Sales.SalesOrderHeader.BillToAddressID, Sales.Customer.AccountNumber " +
                " FROM  Sales.SalesOrderHeader INNER JOIN " +
                " Sales.Customer ON Sales.SalesOrderHeader.CustomerID = Sales.Customer.CustomerID INNER JOIN " +
                " Sales.SalesPerson ON Sales.SalesOrderHeader.SalesPersonID = Sales.SalesPerson.BusinessEntityID " +
                " WHERE Sales.SalesOrderHeader.OrderDate >= @date1 AND Sales.SalesOrderHeader.OrderDate <= @date2", con);
            cmd.Parameters.Add("@date1", SqlDbType.Date).Value = startOfPeriod;
            cmd.Parameters.Add("@date2", SqlDbType.Date).Value = endOfPeriod;
            ModelCollection dt = new ModelCollection(cmd, con);
            dataGrid.ItemsSource = dt;

        }
    }
}
