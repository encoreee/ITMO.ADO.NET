using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class CustomerSelector : Window
    {
        int id;
        NorthwindDataSet northwindDataset;
        SqlConnection northwindConnection;
        SqlDataAdapter sqlDataAdapter;
        public CustomerSelector()
        {
            InitializeComponent();
            var query = "SELECT * FROM Customers";
            northwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);
            sqlDataAdapter = new SqlDataAdapter(query, northwindConnection);
            northwindDataset = new NorthwindDataSet();
            sqlDataAdapter.Fill(northwindDataset, "Customers");
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
