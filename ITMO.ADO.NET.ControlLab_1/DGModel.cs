using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO.NET.ControlLab_1
{
    class DGModel
    {
        public string SalesOrderID { get; set; }
        public string OrderDate { get; set; }
        public string DueDate { get; set; }
        public string ShipDate { get; set; }
        public string TotalDue { get; set; }
        public string ShipToAddressID { get; set; }
        public string BillToAddressID { get; set; }
        public string AccountNumber { get; set; }
    }
    class ModelCollection : ObservableCollection<DGModel>
    {

        public ModelCollection(SqlCommand sqlcomm, SqlConnection sqlconn)
        {

            using (sqlconn)
            {
                sqlconn.Open();
                using (var reader = sqlcomm.ExecuteReader())
                    while (reader.Read())
                    {
                        string od = reader["OrderDate"].ToString();
                        string dd = reader["DueDate"].ToString();
                        string sd = reader["ShipDate"].ToString();
                        DateTime ordDate = Convert.ToDateTime(od);
                        DateTime dueDate = Convert.ToDateTime(od);
                        DateTime shipDate = Convert.ToDateTime(od);

                        Add(new DGModel()
                        {
                            SalesOrderID = reader["SalesOrderID"].ToString(),

                            OrderDate = ordDate.ToShortDateString(),
                            DueDate = dueDate.ToShortDateString(),
                            ShipDate = shipDate.ToShortDateString(),
                            TotalDue = reader["TotalDue"].ToString(),
                            ShipToAddressID = reader["ShipToAddressID"].ToString(),
                            BillToAddressID = reader["BillToAddressID"].ToString(),
                            AccountNumber = reader["AccountNumber"].ToString()
                        });
                    }
                sqlconn.Close();
            }
            
        }
    }

}
