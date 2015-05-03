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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            String nice = "Nice";
            int sweet = nice.Length;
            String UID = ID.Text;

            if (UID.Equals("9999"))
            {
                Admin Next = new Admin();
                
                Next.Show();
                this.Hide();
            }

            else if ((UID.Length == sweet))
            {
                try
                {
                    DBConnect conn = new DBConnect();
                    string query = "select * from rbg354.Customer";
                    SqlCommand myC = new SqlCommand(query, conn.connection);
                    SqlDataReader myR = myC.ExecuteReader();
                
                    while (myR.Read())
                    {
                        if ((UID.Equals(myR["CustomerID"].ToString())))
                        {
                            Customer Next = new Customer(UID);
                            
                            Next.Show();
                            this.Hide();
                        }
                    }
                    conn.CloseConnection();
                }
                
                catch (Exception r)
                {
                    Console.WriteLine(r.Message);
                }
            }
            
            else
            {
                MessageBox.Show("Not cool dude, you are neither a Customer nor an Administrator", "Error");
            }
            
        }
    }
}