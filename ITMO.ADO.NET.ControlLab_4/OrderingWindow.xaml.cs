using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace ITMO.ADO.NET.ControlLab_4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class OrderingWindow : Window
    {
        NorthwindDataSet northwindDataset;
        SqlConnection northwindConnection;
        SqlDataAdapter sqlDataAdapter;
        int orderID;
        int custID;

        public OrderingWindow()
        {
            InitializeComponent();
            order_dp.SelectedDate = DateTime.Today;
            var query = "SELECT * FROM Orders";
            northwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            sqlDataAdapter = new SqlDataAdapter(query, northwindConnection);
            northwindDataset = new NorthwindDataSet();
            sqlDataAdapter.Fill(northwindDataset, "Orders");
            DataTable dt = northwindDataset.Tables["Orders"];


            orderID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int accountLevel = dr.Field<int>("OrderID");
                orderID = Math.Max(orderID, accountLevel);

            }
            this.OrderID_tbx.Text = (orderID + 1).ToString();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            
            int ordID = int.Parse(this.OrderID_tbx.Text);
            string custID = this.CustomerID_tbx.Text;
            int empID = int.Parse(this.EmployeeID_tbx.Text);
            DateTime ? odDate = this.order_dp.SelectedDate;
            DateTime ? rqDate = this.req_dp.SelectedDate;
            DateTime ? shDate = this.shipped_dp.SelectedDate;
            int shipVia = int.Parse(this.ShipVia_tbx.Text);
            decimal freight = decimal.Parse(this.Freight_tbx.Text);
            string shipName = this.ShipName_tbx.Text;
            string shipAddress = this.ShipAddress_tbx.Text;
            string shipCity = this.ShipCity_tbx.Text;
            string shipRegion = this.ShipRegion_tbx.Text;
            string shipPostalCode = this.ShipPostalCode_tbx.Text;
            string shipCountry = this.ShipCountry_tbx.Text;

            DataRow CustRow = northwindDataset.Tables["Orders"].NewRow();
            Object[] CustRecord = {
                ordID.ToString(),
                custID.ToString(),
                empID.ToString(),
                odDate.ToString(),
                rqDate.ToString(),
                shDate.ToString(),
                shipVia.ToString(),
                freight.ToString(),
                shipName.ToString(),
                shipAddress.ToString(),
                shipCity.ToString(),
                shipRegion.ToString(),
                shipPostalCode.ToString(),
                shipCountry.ToString()};


            CustRow.ItemArray = CustRecord;
            northwindDataset.Tables["Orders"].Rows.Add(CustRow);

            new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(northwindDataset.Tables["Orders"]);

            northwindConnection.Close();
            this.Close();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomerSelector order = new CustomerSelector();
            order.Show();
        }
    }
}
