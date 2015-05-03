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
    public partial class PickC : Form
    {

        public PickC()
        {
            InitializeComponent();
        }

        private void PickC_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UID = ID.Text;

            if (UID.Length == 4)
            {
                try
                {
                    DBConnect conn = new DBConnect();
                    string query = "select * from rbg354.Customer";
                    SqlCommand myC = new SqlCommand(query, conn.connection);
                    SqlDataReader myR = myC.ExecuteReader();

                    while (myR.Read())
                    {
                        if (UID.Equals(myR["CustomerID"].ToString()))
                        {
                            UpdateC UPC = new UpdateC(UID);
                            UPC.Show();
                            this.Hide();
                        }
                    }
                  }
                  catch (Exception s)
                  {
                    Console.WriteLine(s.Message);
                  }
            }
            else
            {
                MessageBox.Show("Customer does not exist", "Sorry");
            }

        }

    }
}
