
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ITMO.ADO.NET.DBConnection
{
    partial class Form1
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // diconnectToolStripMenuItem
            // 
            this.diconnectToolStripMenuItem.Name = "diconnectToolStripMenuItem";
            this.diconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diconnectToolStripMenuItem.Text = "Diconnect...";
            this.diconnectToolStripMenuItem.Click += new System.EventHandler(this.diconnectToolStripMenuItem_Click);
            // 
            // asyncConnectToolStripMenuItem
            // 
            this.asyncConnectToolStripMenuItem.Name = "asyncConnectToolStripMenuItem";
            this.asyncConnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asyncConnectToolStripMenuItem.Text = "Async connect...";
            this.asyncConnectToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionListToolStripMenuItem.Text = "Connection list";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
    }

   

}

