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

namespace ITMO.ADO.NET.ControlLab_2
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
             

                var customers = av2017_context.Customers.Join(av2017_context.People,
                                    u => u.PersonID,
                                    c => c.BusinessEntityID,
                                    (u, c) => new ReloadCustomerData()
                                    {
                                        CustomerID = u.CustomerID.ToString(),
                                        FirstName = c.FirstName,
                                        LastName = c.LastName,
                                        StoreID = u.StoreID.ToString(),
                                        TerritoryID = u.TerritoryID.ToString(),
                                        AccountNumber = u.AccountNumber,
                                    }).ToList();

                // var tmp = new BindingList<ReloadCustomerData>(customers);

                this.dataGrid.ItemsSource = customers;
                this.dataGrid.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Employer_item_Click(object sender, RoutedEventArgs e)
        {
            Client_item.IsChecked = false;
            Employer_item.IsChecked = true;
            SaveData_btn.IsEnabled = true;

            av2017_context = new AdventureWorks2017Entities();
            this.dataGrid.ItemsSource = null;
            this.dataGrid.Items.Clear();

            try
            {

                var customers = av2017_context.Customers.Join(av2017_context.People,
                                    u => u.PersonID,
                                    c => c.BusinessEntityID,
                                    (u, c) => new ReloadCustomerData()
                                    {
                                        CustomerID = u.CustomerID.ToString(),
                                        FirstName = c.FirstName,
                                        LastName = c.LastName,
                                        StoreID = u.StoreID.ToString(),
                                        TerritoryID = u.TerritoryID.ToString(),
                                        AccountNumber = u.AccountNumber,
                                    }).ToList().ToBindingList();

                var tmp = new BindingList<ReloadCustomerData>(customers);
                this.dataGrid.ItemsSource = tmp;
                this.dataGrid.IsReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_item_Click(object sender, RoutedEventArgs e)
        {
            Client_item.IsChecked = true;
            Employer_item.IsChecked = false;
            SaveData_btn.IsEnabled = false;
            this.dataGrid.ItemsSource = null;
            this.dataGrid.Items.Clear();

            av2017_context = new AdventureWorks2017Entities();

            try
            {




                var customers = av2017_context.Customers.Join(av2017_context.People,
                                    u => u.PersonID,
                                    c => c.BusinessEntityID,
                                    (u, c) => new ReloadCustomerData()
                                    {
                                        CustomerID = u.CustomerID.ToString(),
                                        FirstName = c.FirstName,
                                        LastName = c.LastName,
                                        StoreID = u.StoreID.ToString(),
                                        TerritoryID = u.TerritoryID.ToString(),
                                        AccountNumber = u.AccountNumber,
                                    }).ToList();

                this.dataGrid.ItemsSource = customers;
                this.dataGrid.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void SaveData_btn_Click(object sender, RoutedEventArgs e)
        {
            ReloadCustomerData cust = (ReloadCustomerData)dataGrid.SelectedItem;

            var customer = av2017_context.Customers
                .Where(c => c.CustomerID.ToString() == cust.CustomerID)
                .FirstOrDefault();
            var people = av2017_context.People
                .Where(c => c.BusinessEntityID.ToString() == customer.PersonID.ToString())
                .FirstOrDefault();

            customer.CustomerID = int.Parse(cust.CustomerID);
            people.FirstName = cust.FirstName;
            people.LastName = cust.LastName;
            customer.StoreID = int.Parse(cust.StoreID);
            customer.TerritoryID = int.Parse(cust.TerritoryID);
            customer.AccountNumber = cust.AccountNumber;

            av2017_context.SaveChanges();
        }
    }

}
