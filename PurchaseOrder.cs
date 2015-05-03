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
    public partial class PurchaseOrder : Form
    {
        private String OID;
        
        public PurchaseOrder(String UID)
        {
            InitializeComponent();
            OID = UID;
            
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            string query = "select * from rbg354.Merchandise";
            DBConnect conn = new DBConnect();
            SqlCommand myC = new SqlCommand(query, conn.connection);
            SqlDataReader myR = myC.ExecuteReader();
            List<String> Items = new List<string>();

            try
            {
                while (myR.Read())
                {
                    Items.Add(myR["ItemID"] + "  " + myR["Name"] + "   " + myR["Description"] + "   Only $" + myR["ListPrice"] + "!!");
                }
                listBox1.DataSource = Items;

            }
            
            catch (Exception i)
            {
                Console.WriteLine(i.ToString());
            }

            conn.CloseConnection();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            double Quantity = Int16.Parse(Qty.Text);
            try
            {
                string query = "select * from rbg354.Merchandise";
                
                DBConnect conn = new DBConnect();
                SqlCommand myC = new SqlCommand(query, conn.connection);
                SqlDataReader myR = myC.ExecuteReader();
                
                string Currently = listBox1.SelectedItem.ToString();
                string cc = Currently.Substring(0,4);

                int SI = listBox1.SelectedIndex;
                while (myR.Read())
                {
                    if (cc.Equals(myR["ItemID"]))
                    {
                        break;
                    }
                }

                double TotalP = double.Parse(myR["ListPrice"].ToString())* Quantity;

                conn.CloseConnection();
                try
                {

                    DateTime DD = DateTime.Parse(DDate.Text);

                    string query2 = "select * from rbg354.Customer where CustomerID = " + OID;
                    DBConnect conn2 = new DBConnect();
                    SqlCommand myC2 = new SqlCommand(query2, conn2.connection);
                    SqlDataReader myR2 = myC2.ExecuteReader();

                    if (myR2.Read()) 
                    {
                        if (double.Parse(myR2["AccountBalance"].ToString()) < TotalP)
                        {
                            MessageBox.Show("You don't have enough to buy this item(s)");
                        }
                        else
                        {
                            Orders O = new Orders(DD, cc, Quantity, OID, myR["ItemID"].ToString(), double.Parse(myR["ListPrice"].ToString()));
                            O.Show();
                        }
                    }
                    
                    conn2.CloseConnection();
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.Message);
                }
            }
            catch (Exception p)
            {
                Console.WriteLine(p.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
