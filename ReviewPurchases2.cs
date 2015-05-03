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
    public partial class ReviewPurchases2 : Form
    {
        private String OID;
        public ReviewPurchases2(String UID)
        {
            InitializeComponent();
            OID = UID;
        }

        private void ReviewPurchases2_Load(object sender, EventArgs e)
        {
            string query = "select C.CustomerID, OrderID, OrderDate from rbg354.Customer as C Inner Join rbg354.PurchaseOrder as PO on C.CustomerID = PO.CustomerID  where CustomerID = OID Order by PO.OrderID ";
            DBConnect conn = new DBConnect();
            SqlCommand myC = new SqlCommand(query, conn.connection);
            SqlDataReader myR = myC.ExecuteReader();
            List<String> Items = new List<string>();
            try
            {
                while (myR.Read())
                {
                    Items.Add("OrderID: " + myR["OrderID"] + "    Order Date: " + myR["OrderDate"] + "    CID: " + myR["CustomerID"]);
                }
                listBox1.DataSource = Items;
            }

            catch (Exception o)
            {
                Console.WriteLine(o.ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
