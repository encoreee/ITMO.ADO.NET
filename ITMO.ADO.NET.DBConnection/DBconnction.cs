using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ITMO.ADO.NET.DBConnection
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null; ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString; connection.Open();
                    MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void diconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close(); MessageBox.Show("Соединение с базой данных закрыто");
            }
            else MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private async void asyncConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " + connection.Database + " выполнено успешно " + "\nСервер: " + connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }

            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            this.connectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            this.asyncConnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            this.diconnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", cs.Name, cs.ProviderName, cs.ConnectionString); MessageBox.Show(str, "Параметры подключений");
                }
            }
        }

        private void btn_prod_count_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Сначала подключитесь к базе");
                    return;
                }
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Products";
                try
                {
                    int number = (int)command.ExecuteScalar();
                    label1.Text = number.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void bnt_scalar_method_Click(object sender, EventArgs e)
        {
            try
            {
                int number = WorkWithDataBase.ExecuteScalarMetod(connectionString, "SELECT COUNT(*) FROM Products");
                label2.Text = number.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_prod_list_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem newItem = listView1.Items.Add(reader["ProductName"].ToString());
                        newItem.SubItems.Add(reader.GetDecimal(1).ToString());
                        newItem.SubItems.Add(reader["QuantityPerUnit"].ToString());
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction sqlTran = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;
                try
                {
                    command.CommandText = "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES('Wrong size', 12, '1 boxes')"; command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES('Wrong color', 25, '100 ml')"; command.ExecuteNonQuery();
                    sqlTran.Commit();
                    MessageBox.Show("Строки записаны в базу данных");

                }
                catch (SqlException ex)
                {
                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        MessageBox.Show(exRollback.Message);
                    }
                }
            }
        }

        private void btn_data_request_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open(); SqlDataReader reader = sqlCommand1.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_batch_request_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                sqlCommand1.CommandText = "SELECT CustomerID, CompanyName " +
                                          "FROM Customers;" +
                                          "SELECT ProductName," +
                                          " UnitPrice," +
                                          " QuantityPerUnit " +
                                          "FROM Products;";

                try
                {
                    sqlConnection1.Open(); SqlDataReader reader = sqlCommand1.ExecuteReader();

                    bool MoreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                results.Append(reader[i].ToString() + "\t");
                            }
                            results.Append(Environment.NewLine);
                        }
                        MoreResults = reader.NextResult();
                    } while (MoreResults);
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_proc_call_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder(); using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand2.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btn_crt_table_Click(object sender, EventArgs e)
        {
            using (sqlConnection1)
            {
                sqlCommand3.CommandText = "CREATE TABLE SalesPersons (" + "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " + "[FirstName] [nvarchar](50) NULL, " + "[LastName] [nvarchar](50) NULL)";
                try
                {
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btn_param_request_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                sqlCommand4.Parameters["@City"].Value = CityTextBox.Text; sqlConnection1.Open();
                SqlDataReader reader = sqlCommand4.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqlConnection1.Close(); }
        }

        private void btn_proc_par_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder(); try
            {
                sqlCommand5.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text; sqlCommand5.Parameters["@OrdYear"].Value = OrdYearTextBox.Text;
                sqlConnection1.Open(); SqlDataReader reader = sqlCommand5.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { sqlConnection1.Close(); }
        }
    }
}
