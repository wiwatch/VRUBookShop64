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
    public partial class frmBooksType : Form
    {
        int EmpID;
        public frmBooksType(int EmpID)
        {
            InitializeComponent();
            this.EmpID = EmpID;
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBooksType_Load(object sender, EventArgs e)
        {
            this.showDgvBookType();
        }
        private void showDgvBookType()
        {
            // สร้างอ็อบเจกต์ของ Model
            VRUBookShop db = new VRUBookShop();
            dgvBookType.DataSource = db.tbBookType.ToList();
        }

        private void tsbShow_Click(object sender, EventArgs e)
        {
            this.showDgvBookType();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            txtBookTypeName.Text = "";
            labBookTypeID.Text = "";
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if(txtBookTypeName.Text=="")
            {
                this.showErrorMessage("ป้อนประเภทหนังสือก่อน");
                return;
            }
            VRUBookShop db = new VRUBookShop();
            tbBookType tb = new tbBookType();
            tb.BookTypeName = txtBookTypeName.Text;
            db.tbBookType.Add(tb);
            db.SaveChanges();
            this.showDgvBookType();
            this.clear();
            //   int bookTypeID = db.tbBookType.Max(bt => bt.BookTypeID);
            //  MessageBox.Show(bookTypeID.ToString());
            var bookType = db.tbBookType.Single(bt => bt.BookTypeID == 12);
           MessageBox.Show(bookType.BookTypeID.ToString());
           
        }
        private void clear()
        {
            txtBookTypeName.Text = "";labBookTypeID.Text = "";txtCondition.Text = "";
        }
        private void showErrorMessage(string text)
        {
            MessageBox.Show(text, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if(labBookTypeID.Text == "")
            {
                this.showErrorMessage("เลือกข้อมูลที่จะแก้ไขก่อน");return;
            }
            int BookTypeID = int.Parse(labBookTypeID.Text);
            VRUBookShop db = new VRUBookShop();
            var bt = db.tbBookType.Single(bts => bts.BookTypeID.Equals(BookTypeID));
            bt.BookTypeName = txtBookTypeName.Text;
            db.SaveChanges();
            this.showDgvBookType();
            this.clear();
        }

        private void dgvBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookTypeName.Text = dgvBookType.Rows[e.RowIndex].Cells["BookTypeName"].Value.ToString();
            labBookTypeID.Text = dgvBookType.Rows[e.RowIndex].Cells["BookTypeID"].Value.ToString();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (labBookTypeID.Text == "")
            {
                this.showErrorMessage("เลือกข้อมูลที่จะลบก่อน"); return;
            }
            DialogResult result;
            result = MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
            int BookTypeID = int.Parse(labBookTypeID.Text);
            VRUBookShop db = new VRUBookShop();
            var bt = db.tbBookType.Single(bts => bts.BookTypeID.Equals(BookTypeID));
            db.tbBookType.Remove(bt);
            db.SaveChanges();
            this.showDgvBookType();
            this.clear();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (txtCondition.Text =="")
            {
                this.showErrorMessage("ใส่รหัสประเภทหรือชื่อประเภทก่อน");return;
            }
            VRUBookShop db = new VRUBookShop();
            
            bool isnumber = int.TryParse(txtCondition.Text, out int BookTypeID);
            if (isnumber)
            {
              var  bt = db.tbBookType.Where(bts => bts.BookTypeID.Equals(BookTypeID));
                dgvBookType.DataSource = bt.ToList();
            }
            else
            {
              var  bt = db.tbBookType.Where(bts => bts.BookTypeName.Contains(txtCondition.Text));
                dgvBookType.DataSource = bt.ToList();
            }
            
        }
    }
}
