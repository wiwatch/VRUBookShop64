using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Manager
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void รายงานพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportEmployee frm = new frmReportEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void รายงานการขายประจำวนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSale frm = new frmReportSale();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
