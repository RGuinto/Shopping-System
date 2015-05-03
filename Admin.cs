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
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateC UPC = new CreateC();
            UPC.Show();
            
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickC PD = new PickC();
            PD.Show();
        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortedReports SR = new SortedReports();
            SR.Show();
        }

        private void createReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TotalReports TR = new TotalReports();
            TR.Show();
        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pastPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

