using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SortedReview : Form
    {
        private String OID;
        public SortedReview(String UID)
        {
            InitializeComponent();
            OID = UID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewPurchases RP = new ReviewPurchases(OID);
            RP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReviewPurchases2 RP2 = new ReviewPurchases2(OID);
            RP2.Show();
        }
    }
}
