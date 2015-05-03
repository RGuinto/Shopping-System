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
    public partial class UpdateC : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter Da = new SqlDataAdapter();

        private String OID;

        public UpdateC(String UID)
        {
            InitializeComponent();
            OID = UID;
        }

        private void UpdateC_Load(object sender, EventArgs e)
        {

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            
            float exec;
            Da.UpdateCommand = new SqlCommand("update rbg354.Customer Set CustomerID = @CustomerID, Name = @Name, Address = @Address, AccountBalance = @AccountBalance WHERE CustomerID = @CustomerID" ,
                conn.connection);

            Da.UpdateCommand.Parameters.Add("@CustomerID", SqlDbType.Char).Value = ID.Text;
            Da.UpdateCommand.Parameters.Add("@Name", SqlDbType.Char).Value = Name.Text;
            Da.UpdateCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address.Text;
            Da.UpdateCommand.Parameters.Add("@AccountBalance", SqlDbType.Float).Value = float.Parse(AccountBalance.Text);

            if (ID.Text.Length % 4 == 0)
            {
                conn.OpenConnection();
                exec = Da.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Customer has been updated!", "Gnarly");

                if (exec >= 1)
                {
                    MessageBox.Show("Customer has been added");
                }
                else
                {
                    MessageBox.Show("Invalid Entries");
                }
            }
            else
            {
                MessageBox.Show("Won't Work");
            }

        }
    }
}
