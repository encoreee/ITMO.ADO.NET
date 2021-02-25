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
using System.Windows.Shapes;

namespace ITMO.ADO.NET.ControlLab_3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class OrderingWindow : Window
    {
        private AdventureWorks2017Entities av2017_context;
        Guid g;
        public OrderingWindow()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            this.OrderDate_tbx.Text = today.ToShortDateString();
            this.dueDate_tbx.Text = today.ToShortDateString();
            this.shipDate_tbx.Text = today.ToShortDateString();

            av2017_context = new AdventureWorks2017Entities();
            this.SalesOrderID_tbx.Text = (av2017_context.SalesOrderHeaders.Max(c => c.SalesOrderID) + 1).ToString();
            g = Guid.NewGuid();
            this.Rowguid_tbx.Text = g.ToString();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {

            int saleID = int.Parse(this.SalesOrderID_tbx.Text);
            byte revNum = byte.Parse(this.RevisionNumber_tbx.Text);

            bool onlineFlag;
            if (this.OnlineOrderFlag_tbx.Text.Equals("0"))
            {
                onlineFlag = false;
            }
            else 
            {
                onlineFlag = true;
            }

            string salesOrdNum = "SO" + saleID.ToString();
            string purchOrdNum = this.PurchaseOrderNumber_tbx.Text;
            string accNum = this.AccountNumber_tbx.Text;
            int custId = int.Parse(this.CustomerID_tbx.Text);
            int selPerID = int.Parse(this.SalesOrderID_tbx.Text);
            int terID = int.Parse(this.TerritoryID_tbx.Text);
            int billToID = int.Parse(this.BillToAddressID_tbx.Text);
            int shipto = int.Parse(this.ShipToAddressID_tbx.Text);
            int shipMethID = int.Parse(this.ShipMethodID_tbx.Text);
            int ccID = int.Parse(this.CreditCardID_tbx.Text);
            string capCode = this.CardApprovalCode_tbx.Text;
            int curRateID = int.Parse(this.CurrencyRateID_tbx.Text);
            decimal subTot = Decimal.Parse(this.SubTotal_tbx.Text);
            decimal taxAmt = Decimal.Parse(this.TaxAmt_tbx.Text);
            decimal freight = Decimal.Parse(this.Freight_tbx.Text);
      
            string comment = this.Comment_tbx.Text;

            if (av2017_context.SalesOrderHeaders.Find(saleID) == null)
            {
                av2017_context.SalesOrderHeaders.Add(new SalesOrderHeader
                {
                    SalesOrderID = saleID,
                    RevisionNumber = revNum,
                    OrderDate = DateTime.Parse(this.OrderDate_tbx.Text),
                    DueDate = DateTime.Parse(this.dueDate_tbx.Text),
                    ShipDate = DateTime.Parse(this.shipDate_tbx.Text),
                    Status = 5,
                    OnlineOrderFlag = onlineFlag,
                    SalesOrderNumber = salesOrdNum,
                    PurchaseOrderNumber = purchOrdNum,
                    AccountNumber = accNum,
                    CustomerID = custId,
                    SalesPersonID = selPerID,
                    TerritoryID = terID,
                    BillToAddressID = billToID,
                    ShipToAddressID = shipto,
                    ShipMethodID = shipMethID,
                    CreditCardID = ccID,
                    CreditCardApprovalCode = capCode,
                    CurrencyRateID = curRateID,
                    SubTotal = subTot,
                    TaxAmt = taxAmt,
                    Freight = freight,
                    Comment = comment,
                    rowguid = g,
                    ModifiedDate = DateTime.Today

                });

            }
            else
            {
                MessageBox.Show("Order is already exist");
            }

            av2017_context.SaveChanges();
            this.Close();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
