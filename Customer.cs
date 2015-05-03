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
    public partial class Customer : Form
    {
        private String OID;
        public Customer(String UID)
        {
            InitializeComponent();
            OID = UID;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void createPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder(OID);
            PO.Show();
        }

        private void reviewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortedReview SR = new SortedReview(OID);
            SR.Show();
        }
    }
}
