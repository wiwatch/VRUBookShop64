using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRUBookShop64.Admin
{
    public partial class frmAdmin : Form
    {
        string EmpName;
        public frmAdmin(string EmpName)
        {
            InitializeComponent();
            this.EmpName = EmpName;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (checkFormOpen())
            {
                return;
            }
           
                // เปิดฟอร์ม ตำแหน่งพนักงาน
                frmPostion frm = new frmPostion();
                frm.MdiParent = this;
                frm.Show(); ;
         

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            tsslUser.Text = "ผู้ใช้ระบบ : " + this.EmpName;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (checkFormOpen())
            {
                return;
            } 
                frmEmployee frm = new frmEmployee();
                frm.MdiParent = this;
                //  frm.Dock = DockStyle.Top;
                frm.Show(); 
            
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void tsbProductType_Click(object sender, EventArgs e)
        {
            if (checkFormOpen())
            {
                return;
            }
               frmBookType frm = new frmBookType();
                frm.MdiParent = this;
                frm.Show();
            
        }

        private bool checkFormOpen()
        {
            bool isOpen = false;
            if (Application.OpenForms.Count > 2)
            {   
                //    MessageBox.Show("มีฟอร์มเปิดอยู่");
                    isOpen = true;
                
            }
            return isOpen;
        }
    }
}
