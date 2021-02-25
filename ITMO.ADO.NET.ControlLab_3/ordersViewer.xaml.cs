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
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ITMO.ADO.NET.ControlLab_3
{

    public partial class salesViewer : Window
    {
        private AdventureWorks2017Entities av2017_context;
        public salesViewer()
        {
            InitializeComponent();
        }

        private void SalesViewer_Loaded(object sender, RoutedEventArgs e)
        {

            av2017_context = new AdventureWorks2017Entities();

            try
            {

                var selOrders = av2017_context.SalesOrderHeaders.Select(
                                    x => new {
                                        SalesOrderID = x.SalesOrderID.ToString(),
                                        RevisionNumber = x.RevisionNumber.ToString(),
                                        OrderDate = x.OrderDate.ToString(),
                                        Status = x.Status.ToString(),
                                        OnlineOrderFlag = x.OnlineOrderFlag.ToString(),
                                        PurchaseOrderNumber = x.PurchaseOrderNumber.ToString(),
                                        AccountNumber = x.AccountNumber,
                                    }).ToList();

                this.dataGrid.ItemsSource = selOrders;
                this.dataGrid.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            av2017_context = new AdventureWorks2017Entities();
            this.dataGrid.ItemsSource = null;
            this.dataGrid.Items.Clear();

            try
            {
                var selOrders = av2017_context.SalesOrderHeaders.Select(
                                    x => new
                                    {
                                        SalesOrderID = x.SalesOrderID.ToString(),
                                        RevisionNumber = x.RevisionNumber.ToString(),
                                        OrderDate = x.OrderDate.ToString(),
                                        Status = x.Status.ToString(),
                                        OnlineOrderFlag = x.OnlineOrderFlag.ToString(),
                                        PurchaseOrderNumber = x.PurchaseOrderNumber.ToString(),
                                        AccountNumber = x.AccountNumber,
                                    }).ToList();

                this.dataGrid.ItemsSource = selOrders;
                this.dataGrid.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newOrder_btn_Click(object sender, RoutedEventArgs e)
        {
            OrderingWindow order = new OrderingWindow();
            order.Show();
        }
    }

}
