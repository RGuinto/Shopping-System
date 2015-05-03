using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DBConnect
    {
        public SqlConnection connection;
        private string server;
        private string database;

        //Constructor
        public DBConnect()
        {
            Initialize();
            OpenConnection();
        }

        public void Initialize()
        {
            server = "cypress.csil.sfu.ca";
            database = "rbg354";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "integrated security= sspi;";

            connection = new SqlConnection(connectionString);
            
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SqlCommand()
        {
            SqlCommand myC = new SqlCommand("Command String", connection);
        }

        public void SqlDataReader()
        {
            try
            {
                SqlDataReader myR = null;
                SqlCommand myC = new SqlCommand("select * from rbg354.Customer", connection);
                myR = myC.ExecuteReader();
                while (myR.Read())
                {
                    //Console.WriteLine(myR["Column1"].ToString());
                    //myR.GetInt32(0);
                    //myR.GetString(1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

}
