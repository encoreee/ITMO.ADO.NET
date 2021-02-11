
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ITMO.ADO.NET.DBConnection
{
    partial class s
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        SqlConnection connection = new SqlConnection();
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        //string connectionString = @"Data Source=WS-45\SQLEXPRESS;
        //                            Initial Catalog=Northwind;
        //                            Integrated Security=true";

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_prod_count = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_scalar_method = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_prod_list = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_transaction = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btn_data_request = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.btn_batch_request = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.btn_proc_call = new System.Windows.Forms.Button();
            this.btn_crt_table = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.btn_param_request = new System.Windows.Forms.Button();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.btn_proc_par = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBOperationsToolStripMenuItem
            // 
            this.dBOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.diconnectToolStripMenuItem,
            this.asyncConnectToolStripMenuItem,
            this.connectionListToolStripMenuItem});
            this.dBOperationsToolStripMenuItem.Name = "dBOperationsToolStripMenuItem";
            this.dBOperationsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dBOperationsToolStripMenuItem.Text = "DB operations";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // diconnectToolStripMenuItem
            // 
            this.diconnectToolStripMenuItem.Name = "diconnectToolStripMenuItem";
            this.diconnectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.diconnectToolStripMenuItem.Text = "Diconnect...";
            this.diconnectToolStripMenuItem.Click += new System.EventHandler(this.diconnectToolStripMenuItem_Click);
            // 
            // asyncConnectToolStripMenuItem
            // 
            this.asyncConnectToolStripMenuItem.Name = "asyncConnectToolStripMenuItem";
            this.asyncConnectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.asyncConnectToolStripMenuItem.Text = "Async connect...";
            this.asyncConnectToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.connectionListToolStripMenuItem.Text = "Connection list";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // btn_prod_count
            // 
            this.btn_prod_count.Location = new System.Drawing.Point(12, 27);
            this.btn_prod_count.Name = "btn_prod_count";
            this.btn_prod_count.Size = new System.Drawing.Size(108, 23);
            this.btn_prod_count.TabIndex = 1;
            this.btn_prod_count.Text = "Product count";
            this.btn_prod_count.UseVisualStyleBackColor = true;
            this.btn_prod_count.Click += new System.EventHandler(this.btn_prod_count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // bnt_scalar_method
            // 
            this.bnt_scalar_method.Location = new System.Drawing.Point(13, 57);
            this.bnt_scalar_method.Name = "bnt_scalar_method";
            this.bnt_scalar_method.Size = new System.Drawing.Size(107, 23);
            this.bnt_scalar_method.TabIndex = 3;
            this.bnt_scalar_method.Text = "Scalar method";
            this.bnt_scalar_method.UseVisualStyleBackColor = true;
            this.bnt_scalar_method.Click += new System.EventHandler(this.bnt_scalar_method_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // btn_prod_list
            // 
            this.btn_prod_list.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prod_list.Location = new System.Drawing.Point(13, 87);
            this.btn_prod_list.Name = "btn_prod_list";
            this.btn_prod_list.Size = new System.Drawing.Size(107, 23);
            this.btn_prod_list.TabIndex = 5;
            this.btn_prod_list.Text = "Product list";
            this.btn_prod_list.UseVisualStyleBackColor = true;
            this.btn_prod_list.Click += new System.EventHandler(this.btn_prod_list_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(356, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 224);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product list";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity per unit";
            this.columnHeader3.Width = 100;
            // 
            // btn_transaction
            // 
            this.btn_transaction.Location = new System.Drawing.Point(12, 117);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(108, 23);
            this.btn_transaction.TabIndex = 7;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=WS-45\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // btn_data_request
            // 
            this.btn_data_request.Location = new System.Drawing.Point(12, 147);
            this.btn_data_request.Name = "btn_data_request";
            this.btn_data_request.Size = new System.Drawing.Size(108, 23);
            this.btn_data_request.TabIndex = 8;
            this.btn_data_request.Text = "Data request";
            this.btn_data_request.UseVisualStyleBackColor = true;
            this.btn_data_request.Click += new System.EventHandler(this.btn_data_request_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(356, 257);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(596, 218);
            this.ResultsTextBox.TabIndex = 9;
            // 
            // btn_batch_request
            // 
            this.btn_batch_request.Location = new System.Drawing.Point(12, 176);
            this.btn_batch_request.Name = "btn_batch_request";
            this.btn_batch_request.Size = new System.Drawing.Size(108, 23);
            this.btn_batch_request.TabIndex = 10;
            this.btn_batch_request.Text = "Batch request";
            this.btn_batch_request.UseVisualStyleBackColor = true;
            this.btn_batch_request.Click += new System.EventHandler(this.btn_batch_request_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // btn_proc_call
            // 
            this.btn_proc_call.Location = new System.Drawing.Point(12, 206);
            this.btn_proc_call.Name = "btn_proc_call";
            this.btn_proc_call.Size = new System.Drawing.Size(108, 23);
            this.btn_proc_call.TabIndex = 11;
            this.btn_proc_call.Text = "Procedure call";
            this.btn_proc_call.UseVisualStyleBackColor = true;
            this.btn_proc_call.Click += new System.EventHandler(this.btn_proc_call_Click);
            // 
            // btn_crt_table
            // 
            this.btn_crt_table.Location = new System.Drawing.Point(12, 237);
            this.btn_crt_table.Name = "btn_crt_table";
            this.btn_crt_table.Size = new System.Drawing.Size(107, 23);
            this.btn_crt_table.TabIndex = 12;
            this.btn_crt_table.Text = "Create table";
            this.btn_crt_table.UseVisualStyleBackColor = true;
            this.btn_crt_table.Click += new System.EventHandler(this.btn_crt_table_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // btn_param_request
            // 
            this.btn_param_request.Location = new System.Drawing.Point(12, 266);
            this.btn_param_request.Name = "btn_param_request";
            this.btn_param_request.Size = new System.Drawing.Size(107, 23);
            this.btn_param_request.TabIndex = 13;
            this.btn_param_request.Text = "Request with par";
            this.btn_param_request.UseVisualStyleBackColor = true;
            this.btn_param_request.Click += new System.EventHandler(this.btn_param_request_Click);
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(143, 269);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 14;
            this.CityTextBox.Text = "London";
            // 
            // btn_proc_par
            // 
            this.btn_proc_par.Location = new System.Drawing.Point(12, 296);
            this.btn_proc_par.Name = "btn_proc_par";
            this.btn_proc_par.Size = new System.Drawing.Size(107, 23);
            this.btn_proc_par.TabIndex = 15;
            this.btn_proc_par.Text = "Procedure with par";
            this.btn_proc_par.UseVisualStyleBackColor = true;
            this.btn_proc_par.Click += new System.EventHandler(this.btn_proc_par_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(143, 298);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameTextBox.TabIndex = 16;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(250, 298);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrdYearTextBox.TabIndex = 17;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 635);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.btn_proc_par);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.btn_param_request);
            this.Controls.Add(this.btn_crt_table);
            this.Controls.Add(this.btn_proc_call);
            this.Controls.Add(this.btn_batch_request);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.btn_data_request);
            this.Controls.Add(this.btn_transaction);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_prod_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnt_scalar_method);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_prod_count);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "s";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        private System.Windows.Forms.Button btn_prod_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_scalar_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_prod_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_transaction;
        private SqlConnection sqlConnection1;
        private SqlCommand sqlCommand1;
        private System.Windows.Forms.Button btn_data_request;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button btn_batch_request;
        private SqlCommand sqlCommand2;
        private System.Windows.Forms.Button btn_proc_call;
        private System.Windows.Forms.Button btn_crt_table;
        private SqlCommand sqlCommand3;
        private System.Windows.Forms.Button btn_param_request;
        private SqlCommand sqlCommand4;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button btn_proc_par;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private SqlCommand sqlCommand5;
    }

   

}

