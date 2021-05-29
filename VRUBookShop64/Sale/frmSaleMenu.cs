using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Sale
{
    public partial class frmSaleMenu : Form
    {
        string EmpName,EmpID;
        public frmSaleMenu(string EmpName,string EmpID)
        {
            InitializeComponent();
            this.EmpName = EmpName;
            this.EmpID = EmpID;
        }

        private void frmSaleMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "ผู้ใช้ระบบ : " + this.EmpName;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // เปิด frmSale
            frmSale frm = new frmSale(this.EmpName,this.EmpID);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
