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
        string EmpName;
        public frmSaleMenu(string EmpName)
        {
            InitializeComponent();
            this.EmpName = EmpName;
        }

        private void frmSaleMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "ผู้ใช้ระบบ : " + this.EmpName;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
