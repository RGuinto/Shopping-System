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
    public partial class Orders : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter Da = new SqlDataAdapter();
        private DateTime DDate;
        private string orderID;
        private double quant;
        private String OID;
        private string ItemID;
        private double ListPrice;

        public Orders(DateTime Date, string cc, double Qnt, string UID, string IID, double LP)
        {
            InitializeComponent();
            DDate = Date;
            orderID = cc;
            quant = Qnt;
            OID = UID;
            ItemID = IID;
            ListPrice = LP;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            List<String> Items = new List<string>();
            Items.Add(ItemID + "  " + orderID + "  " + ListPrice.ToString());
            listBox1.DataSource = Items;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float exec;
            try
            {
                Da.InsertCommand = new SqlCommand("insert into rbg354.PurcahseOrder(OrderID, CustomerID, DeliveryDate, OrderDate)" +
                        "values(@OrderID, @CustomerID, @DeliveryDate, @OrderDate)", conn.connection);
                Da.InsertCommand.Parameters.Add("@OrderID", SqlDbType.Char).Value = orderID;
                Da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Char).Value = OID;
                Da.InsertCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = DDate;
                Da.InsertCommand.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = DateTime.Now;

                exec = Da.InsertCommand.ExecuteNonQuery();
                conn.CloseConnection();
                try
                {
                    Da.InsertCommand = new SqlCommand("insert into rbg354.OrderDetail(OrderID, ItemID, UnitPrice, Qty)" +
                            "values(@OrderID, @ItemID, @UnitPrice, @Qty)", conn.connection);
                    Da.InsertCommand.Parameters.Add("@OrderID", SqlDbType.Char).Value = orderID;
                    Da.InsertCommand.Parameters.Add("@ItemID", SqlDbType.Char).Value = ItemID;
                    Da.InsertCommand.Parameters.Add("@UnitPrice", SqlDbType.Float).Value = ListPrice;
                    Da.InsertCommand.Parameters.Add("@Qty", SqlDbType.Decimal).Value = quant;

                    exec = Da.InsertCommand.ExecuteNonQuery();

                    
                }
                catch (Exception y)
                {
                    Console.WriteLine(y.Message);
                }
                conn.CloseConnection();
            }
            catch (Exception y)
            {
                Console.WriteLine(y.Message);
            }

            MessageBox.Show("I have taken your money and you have acquired my item", "hehehe, you have made your decision" );
            try
            {
                string Cquery = "select * from rbg354.Customer where CustomerID = " + OID;
                DBConnect Cconn = new DBConnect();
                SqlCommand CmyC = new SqlCommand(Cquery, Cconn.connection);
                SqlDataReader CmyR = CmyC.ExecuteReader();

                Da.InsertCommand = new SqlCommand("insert into rbg354.Customer(AccountBalance)" +
                            "values(@AccountBalance)", Cconn.connection);
                Da.UpdateCommand.Parameters.Add("@AccountBalance", SqlDbType.Float).Value = float.Parse(CmyR["AccountBalance"].ToString()) - ListPrice;

                exec = Da.UpdateCommand.ExecuteNonQuery();
                Cconn.CloseConnection();
            }
            catch (Exception y)
            {
                Console.WriteLine(y.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
