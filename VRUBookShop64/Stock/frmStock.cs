using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Stock
{
    public partial class frmStock : Form
    {
        int EmpID;
        public frmStock(int EmpID)
        {
            InitializeComponent();
            this.EmpID = EmpID;
        }

        private void tsbProductType_Click(object sender, EventArgs e)
        {
            frmBooksType frm = new frmBooksType(this.EmpID);
            frm.MdiParent= this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {

        }
    }
}
