using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class TotalReports : Form
    {
        public TotalReports()
        {
            InitializeComponent();
        }

        private void TotalReports_Load(object sender, EventArgs e)
        {
            //this query should be correct, if there are no items in the listbox it just means that there are no items in the table :(
            string query = "select rbg354.PurchaseOrder.OrderDate, COUNT (rbg354.PurchaseOrder.OrderDate) as #Orders, SUM (rbg354.OrderDetail.UnitPrice) as TSales From rbg354.PurchaseOrder INNER JOIN rbg354.OrderDetail On rbg354.PurchaseOrder.OrderID = rbg354.OrderDetail.OrderID GROUP BY rbg354.PurchaseOrder.OrderDate ORDER BY rbg354.PurchaseOrder.OrderDate DESC";
            DBConnect conn = new DBConnect();
            SqlCommand myC = new SqlCommand(query, conn.connection);
            SqlDataReader myR = myC.ExecuteReader();
            List<String> Items = new List<string>();

            try
            {
                while (myR.Read())
                {
                    Items.Add("Order Date: " + myR["OrderDate"] + "    Order ID: " + myR["OrderID"] + "    Unit Price: " + myR["UnitPrice"]);
                }
                listBox1.DataSource = Items;
            }

            catch (Exception o)
            {
                Console.WriteLine(o.ToString());
            }

            conn.CloseConnection();
        }
    }
}
