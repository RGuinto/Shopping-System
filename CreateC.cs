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
    public partial class CreateC : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter Da = new SqlDataAdapter();

        public CreateC()
        {
            InitializeComponent();
        }

        private void CreateC_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            float exec;
            Da.InsertCommand = new SqlCommand("insert into rbg354.Customer(CustomerID, Name, Address, AccountBalance)" +
                "values(@CustomerID, @Name, @Address, @AccountBalance)", conn.connection);
            Da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Char).Value = ID.Text;
            Da.InsertCommand.Parameters.Add("@Name", SqlDbType.Char).Value = Name.Text;
            Da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address.Text;
            Da.InsertCommand.Parameters.Add("@AccountBalance", SqlDbType.Float).Value = float.Parse(AccountB.Text);

            if (ID.Text.Length % 4 == 0)
            {
                MessageBox.Show("Awesome! Account has been created!", "Success");
                conn.OpenConnection();
                exec = Da.InsertCommand.ExecuteNonQuery();
                ID.Clear();
                Name.Clear();
                Address.Clear();
                AccountB.Clear();

                conn.CloseConnection();

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
                MessageBox.Show("Invalid Customer ID, need 4 digit ID");
            }

        }

    }
}
